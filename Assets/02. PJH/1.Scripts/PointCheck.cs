using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PointCheck : MonoBehaviour
{
    bool pointCheck = false;
    Vector3 playerPosition;
    Vector3 EnemyPosition;
	public PlayerAnimation animator;
    //public GameObject GM;

    private void Awake()
    {
        //GM.GetComponent<GameManager>();
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
    }
    private void Start()
	{
		animator.GetComponent<PlayerAnimation>();

	}

    private void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"&&pointCheck == false)
        {
            //플레이어가 장애물 위에 착지했을 때 플레이어와 장애물의 X,Z 위치를 비교하여 점수를 측정하는 코드
            float distanceCheck;

            playerPosition = new Vector3(collision.gameObject.transform.position.x,0, collision.gameObject.transform.position.z);
            EnemyPosition = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);

            distanceCheck = Vector3.Distance(playerPosition, EnemyPosition);



            if(distanceCheck<0.1)
            {
                GameManager.score += 5 * GameManager.GHigh;
                Debug.Log("Perfact");
                animator.PerfactAnimation();
			}
            else if(distanceCheck <0.3)
            {
                GameManager.score += 3 * GameManager.GHigh;
                Debug.Log("Excellent");
                animator.ExcellentAnimation();
			}
            else if(distanceCheck < 0.5)
            {
                GameManager.score += 2 * GameManager.GHigh;
                Debug.Log("Good");
                animator.GoodAnimation();
			}
            else
            {
                //GameManager.score += 10 * GameManager.GHigh;
                Debug.Log("Bad");
                animator.BadAnimation();
			}

          

            pointCheck = true;
            
        }
        
    }
}
