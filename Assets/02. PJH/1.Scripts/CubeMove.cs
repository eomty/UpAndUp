using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    Transform playerTr;
    public GameObject player;
    private Vector3 MPosition;
    private Vector3 termP;
    public bool playerOn;
    public float speed;
    bool isNotDie = true;

    //플레이어의 위치를 받아 생성된 위치에서 플레이어까지의 거리에 두배를 저장하는 코드
    private void Start()
    {
        playerTr = player.GetComponent<Transform>();


        MPosition = playerTr.position - transform.position;
        termP = MPosition;
        MPosition = new Vector3(termP.x, transform.position.y, termP.z);
        playerOn = false;
        speed = Random.Range(4,4);
     }

    // Update is called once per frame
    void Update()
    {
        CMove();

        if (MPosition == gameObject.transform.position && isNotDie )
        {
            Debug.Log("죽었멍");
            isNotDie = false;
        }

    }
    
    //MPosition 만큼 이동하는 코드
    public void CMove()
    {
        if (playerOn == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, MPosition, speed * Time.deltaTime);
        }

    }


}
