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

    private void Awake()
    {
        cubeInit = GetComponent<CubeInit>();
        CM = GetComponent<CubeMove>();
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
                if (distanceCheck <= thisRadius * 0.25)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("Ex");
                    GameManager.high += 1;

                    CM.playerOn = true; //장애물의 움직임을 끄는 코드
                }
                else if (distanceCheck <= thisRadius * 0.6)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("perfact");
                    GameManager.high += 1;

                    CM.playerOn = true; //장애물의 움직임을 끄는 코드
                }
                else if (distanceCheck <= thisRadius * 0.8)
                {
                    cubeInit.ObstacleCreate();
                    Debug.Log("good");
                    GameManager.high += 1;

                    CM.playerOn = true; //장애물의 움직임을 끄는 코드
                }
                else
                {
                    cubeInit.ObstacleCreate();
                    GameManager.high += 1;

                    CM.playerOn = true;
                    Debug.Log("Bad");
                }

                isDone = true;
            }


        }


    }

    
}
