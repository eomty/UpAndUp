using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript1 : MonoBehaviour
{
    public GameObject player;
    Vector3 playerPosition;
    Vector3 EnemyPosition;
    CubeMove CM;
    PlayerDie die;
    PlayerAnimation playAnimation;
    PlayerJump playerjump;


    private void Awake()
    {
        CM = GetComponent<CubeMove>();
        die = GetComponent<PlayerDie>();

        playAnimation = GameObject.FindWithTag("Model").GetComponent<PlayerAnimation>();
        //playerjump = GameObject.Find("Player").GetComponent<PlayerJump>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Player")
        {     
                    //die.CallDie();
                    CM.playerOn = true;

                   playAnimation.ExcellentAnimation();
                }
            }


        }


    

    

