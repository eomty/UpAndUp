using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class PointCheck : MonoBehaviour
{
   
    public GameObject obstacle;
    Vector3 playerPosition;
    Vector3 EnemyPosition;
	public PlayerAnimation animator;
    float thisRadius;
    //public GameObject GM;


    public void PointGet(Collider collider)
    {
        gameObject.transform.parent.GetComponent<
            PlayerDie>().isCanDie = false;

        float distanceCheck;

        playerPosition = new Vector3(collider.gameObject.transform.position.x, 0, collider.gameObject.transform.position.z);
        EnemyPosition = new Vector3(obstacle.transform.position.x, 0, obstacle.transform.position.z);

        distanceCheck = Vector3.Distance(playerPosition, EnemyPosition);

        thisRadius = gameObject.GetComponent<RectTransform>().localScale.x / 2;//오브젝트의 반지름을 구하는 코드

        if (distanceCheck <= thisRadius * 0.25)
        {
            Debug.Log("Ex");
        }
        else if (distanceCheck <= thisRadius * 0.6)
        {
            Debug.Log("perfact");
        }
        else if (distanceCheck <= thisRadius * 0.8)
        {
            Debug.Log("good");
        }
        else
        {
            Debug.Log("Bad");
        }

    }

}
