using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public GameObject player;
    Vector3 playerPosition;
    Vector3 EnemyPosition;
    float thisRadius;
    CubeInit cubeInit;
    bool isDone = false;
    CubeMove CM;
    PlayerDie die;
    PlayerAnimation playAnimation;
    ResetText resettext;
    //ResetTextNum resetTextNum;
    ResetTextNum resettextnum;
    PlayerJump playerjump;


    private void Awake()
    {
        cubeInit = GetComponent<CubeInit>();
        CM = GetComponent<CubeMove>();
        die = GetComponent<PlayerDie>();
        resettext = GameObject.Find("PxExGoBad").GetComponent<ResetText>();
        //resettextnum = GameObject.FindWithTag("MainC").transform.Find("ScoreText").gameObject;
        resettextnum = GameObject.FindWithTag("ScoreText").GetComponentInChildren<ResetTextNum>();
        playAnimation = GameObject.FindWithTag("Model").GetComponent<PlayerAnimation>();
        playerjump = GameObject.Find("Player").GetComponent<PlayerJump>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Player")
        {

            if(isDone ==false)
            {
                float distanceCheck;
                playerPosition = new Vector3(collision.gameObject.transform.position.x, 0,
                    collision.gameObject.transform.position.z);
                EnemyPosition = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);

                distanceCheck = Vector3.Distance(playerPosition, EnemyPosition);
                Debug.Log("0.9이상 사망"+distanceCheck);

                thisRadius = Mathf.Pow(GetComponent<BoxCollider>().size.x * GetComponent<BoxCollider>().size.z, 0.5f) /2;//오브젝트의 반지름을 구하는 코드
                
                //Debug.Log(thisRadius);                   //임시로 제거
                if (distanceCheck <= thisRadius * 0.25)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("perfect");
                    CM.playerOn = true;
                    playAnimation.PerfactAnimation();
                    GameManager.TextNum = 1;
                    resettext.TextCreate();
                    resettextnum.TextScoreCreate();

                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 500;
                    GameManager.score += 500 * GameManager.high;
                    
                }
                else if (distanceCheck <= thisRadius * 0.5)
                {
                  
                    cubeInit.ObstacleCreate();
                    Debug.Log("Ex");
                    CM.playerOn = true;
                    playAnimation.ExcellentAnimation();
                    GameManager.TextNum = 2;
                    resettext.TextCreate();
                    resettextnum.TextScoreCreate();
                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 300;
                    GameManager.score += 300 * GameManager.high;

                }
                else if (distanceCheck <= thisRadius * 0.8)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("good");
                    CM.playerOn = true;
                    playAnimation.GoodAnimation();
                    GameManager.TextNum = 3;
                    resettext.TextCreate();
                    resettextnum.TextScoreCreate();

                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 100;
                    GameManager.score += 100 * GameManager.high;
                }
                else
                {
                    //playerjump.rig.AddRelativeForce(new Vector3(1,1,1) * 1000f * Time.deltaTime, ForceMode.Impulse); //AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
                    //playerjump.transform.Rotate(-EnemyPosition);
                    GameManager.TextNum = 4; //Not Canvas so Not Bad
                    resettext.TextCreate();
                    cubeInit.ObstacleCreate();
                    die.CallDie();
                    CM.playerOn = true;
                    Debug.Log("Bad");
                    playAnimation.DieAnimation();
                    GameManager.GameDataSave(GameManager.isPlayerDie);
                }

                isDone = true;
            }


        }


    }

    
}
