using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    
    Vector3 playerPosition;
    Vector3 EnemyPosition;
    //public PlayerAnimation animator;
    float thisRadius;
    CubeInit cubeInit;
    bool isDone = false;
    CubeMove CM;
    PlayerDie die;
    public PlayerAnimation MyAnimator;
    private void Awake()
    {
        cubeInit = GetComponent<CubeInit>();
        CM = GetComponent<CubeMove>();
        die = GetComponent<PlayerDie>();
        //MyAnimator = GetComponent<PlayerAnimation>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Player")
        {

            if(isDone ==false)
            {
                float distanceCheck;
                playerPosition = new Vector3(collision.gameObject.transform.position.x, 0, collision.gameObject.transform.position.z);
                EnemyPosition = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);

                distanceCheck = Vector3.Distance(playerPosition, EnemyPosition);
                Debug.Log(distanceCheck);

                thisRadius = Mathf.Pow(GetComponent<BoxCollider>().size.x * GetComponent<BoxCollider>().size.z, 0.5f) /2;//오브젝트의 반지름을 구하는 코드

                Debug.Log(thisRadius);
                if (distanceCheck <= thisRadius * 0.6)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("Ex");
                    MyAnimator.ExcellentAnimation();
                    
                    CM.playerOn = true; //장애물의 움직임을 끄는 코드

                    GameManager.score += 500 * GameManager.high;
                }
                else if (distanceCheck <= thisRadius * 0.25)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("perfact");
                    MyAnimator.PerfactAnimation();

                    CM.playerOn = true; //장애물의 움직임을 끄는 코드

                    GameManager.score += 300 * GameManager.high;
                }
                else if (distanceCheck <= thisRadius * 0.8)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("good");
                    MyAnimator.GoodAnimation();

                    CM.playerOn = true; //장애물의 움직임을 끄는 코드

                    GameManager.score += 100 * GameManager.high;
                }
                else
                {

                    cubeInit.ObstacleCreate();
                    die.CallDie();
                    CM.playerOn = true;
                    Debug.Log("Bad");
                    
                    GameManager.GameDataSave(GameManager.isPlayerDie);
                }

                isDone = true;
            }


        }


    }

    
}
