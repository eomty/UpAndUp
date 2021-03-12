using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public GameObject player;
    public float jumpPower = 0;
    public float distToGround = 0.6f;
    bool grounded = false;
    bool jumpT = false;
    Rigidbody rig;
    float touchnMoveDistance = 0;

    private void Start()
    {
        rig = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
        Vector3 rayPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z);
        Debug.DrawRay(rayPosition, Vector3.down, Color.green, distToGround);
     
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 moveDistance = Input.GetTouch(0).deltaPosition;
            touchnMoveDistance += moveDistance.y;
        
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            jumpPower = touchnMoveDistance ;
            Jump();

            touchnMoveDistance = 0;
        }

        if ((grounded) && jumpT ==true )
        {
            rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
            jumpT = false;
         
        }

     
        /*  if (Input.touchCount > 0)
          {
              Touch touch = Input.GetTouch(0);
              switch (touch.phase)
              {
                  case TouchPhase.Began:
                      Debug.Log("TouchPhase Began!");

                      break;

                  case TouchPhase.Moved:
                      Vector3 MoveDistancd = Input.GetTouch(0).deltaPosition;
                      TouchnMoveDistance += (MoveDistancd.y*100);

                      break;

                  case TouchPhase.Ended:
                      jumpPower = TouchnMoveDistance;
                      Jump();


                      break;

                  case TouchPhase.Canceled:
                      Debug.Log("TouchPhase Canceled!");

                      break;
              }
          }*/


    }

    public void Jump()
    {
        jumpT = true;
      
    }

    private void CheckGround()
    {
        //Debug.DrawRay(gameObject.transform.position, Vector3.down * 100, Color.red);
        if (Physics.Raycast(gameObject.transform.position, Vector3.down, distToGround))
        {
            grounded = true;
            return;
        }
        grounded = false;
        jumpT = false;
    }


}
