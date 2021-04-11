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
    AutoActiveFalse autoActiveFalse;
    AutoDestroy autoDestroy;
    Music soundSet;
    int obstacleDestroyHigh;

    private void Awake()
    {
        cubeInit = GetComponent<CubeInit>();
        CM = GetComponent<CubeMove>();
        die = GetComponent<PlayerDie>();
        resettext = GameObject.Find("PxExGoBad").GetComponent<ResetText>();
        autoActiveFalse = GameObject.Find("PxExGoBad").GetComponent<AutoActiveFalse>();
        autoDestroy = GameObject.Find("ScoreTextNum").GetComponent<AutoDestroy>();
        //resettextnum = GameObject.FindWithTag("MainC").transform.Find("ScoreText").gameObject;
        resettextnum = GameObject.FindWithTag("ScoreText").GetComponentInChildren<ResetTextNum>();
        playAnimation = GameObject.FindWithTag("Model").GetComponent<PlayerAnimation>();
        playerjump = GameObject.Find("Player").GetComponent<PlayerJump>();
        soundSet = GameObject.Find("AudioManager").GetComponent<Music>();
        obstacleDestroyHigh = GameManager.high + 20;
    }
    private void Update()
    {
        if(obstacleDestroyHigh == GameManager.high)
        {
            gameObject.SetActive(false);
        }
    }

    public void TextActiveDestroy()
    {
        resettext.TextCreate();
        resettextnum.TextScoreCreate();
        autoActiveFalse.TextCreate1();
        autoDestroy.TextCreate2();
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
                //Debug.Log("0.9이상 사망"+distanceCheck);

                thisRadius = Mathf.Pow(GetComponent<BoxCollider>().size.x * GetComponent<BoxCollider>().size.z, 0.5f) /2;//오브젝트의 반지름을 구하는 코드
                
                //Debug.Log(thisRadius);                   //임시로 제거
                if (distanceCheck <= thisRadius * 0.25)
                {
                    TextActiveDestroy();

                    soundSet.PerfectSoundChange();
					//GameObject.Find("Perfect").GetComponent<AudioSource>().Play();
					cubeInit.ObstacleCreate();
                    Debug.Log("Perfect");
                    CM.playerOn = true;
                    playAnimation.PerfactAnimation();
                    GameManager.TextNum = 1;
                  

                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 5;
                    GameManager.score += 5 * GameManager.high;
                    
                }
                else if (distanceCheck <= thisRadius * 0.55)
                {
                    TextActiveDestroy();

                    //GameObject.Find("Excellent").GetComponent<AudioSource>().Play();
                    soundSet.ExcellentSoundChange();
					cubeInit.ObstacleCreate();
                    Debug.Log("Excellent");
                    CM.playerOn = true;
                    playAnimation.ExcellentAnimation();
                    GameManager.TextNum = 2;
                 
                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 3;
                    GameManager.score += 3 * GameManager.high;

                }
                else if (distanceCheck <= thisRadius * 1)
                {
                    TextActiveDestroy();

                    //GameObject.Find("Good").GetComponent<AudioSource>().Play();
                    soundSet.GoodSoundChange();
					cubeInit.ObstacleCreate();
                    Debug.Log("Good");
                    CM.playerOn = true;
                    playAnimation.GoodAnimation();
                    GameManager.TextNum = 3;
                  

                    //장애물의 움직임을 끄는 코드
                    GameManager.scoreNum = 1;
                    GameManager.score += 1 * GameManager.high;
                }

                else
                {
                    GameManager.TextNum = 4; //Not Canvas so Not Bad
                                             //resettext.TextCreate();
                    cubeInit.ObstacleCreate();
                    die.CallDie();
                    //GameObject.Find("Die").GetComponent<AudioSource>().Play();
                    soundSet.DieSoundChange();
                    CM.playerOn = true;
                    Debug.Log("죽었습니다.");
                    playAnimation.DieAnimation();
                    GameManager.GameDataSave(GameManager.isPlayerDie);
                }
		
				isDone = true;
            }


        }


    }

    
}
