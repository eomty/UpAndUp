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
    PlayerDie die;
    bool isEnd = false ;


    private void Start()
    {
        playerTr = player.GetComponent<Transform>();
        die = GetComponent<PlayerDie>();
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
        if (gameObject.transform.position == MPosition)
        {
            if(isEnd == false)
            {
                die.CallDie();
                isEnd = true;
            }
        }
    }

    public void CMove()
    {
        if (playerOn == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, MPosition, speed * Time.deltaTime);
        }

    }


}
