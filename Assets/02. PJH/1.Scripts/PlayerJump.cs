using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public GameObject player;
    public float jumpPower = 0;
    public float distToGround = 0.6f;
    bool grounded = false;
    bool isJump = false;
    bool jumpT = false;
    Rigidbody rig;
    float touchnMoveDistance = 0;
	public PlayerAnimation MyAnimator;

    private void Start()
    {
        rig = player.GetComponent<Rigidbody>();
		MyAnimator =GetComponentInChildren<PlayerAnimation>();
    }


    private void FixedUpdate()
    {   //터치했을시 이동한 Y값을 저장
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 moveDistance = Input.GetTouch(0).deltaPosition;
            touchnMoveDistance += moveDistance.y;
        
        }
        //저장된 Y값을 점프파워로 반환하는 코드
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            jumpPower = touchnMoveDistance ;
            Jump();

            touchnMoveDistance = 0;
        }

        //땅이고 점프하는 것이 맞다면 AddForce로 플레이어를 Y축으로만 올려주는 코드
        //if ((grounded) && jumpT == true && isJump == true)
        if(jumpT == true && isJump == true)
        {
            Debug.Log(grounded);
            rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
			MyAnimator.JumpAnimaion();
			jumpT = false;
            isJump = false;
         
        }

     //터치를 스위치 문으로 구현하려 했지만 된건지 안된건지 몰라 주석처리해둠
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
    {//점프를 FixedUpdate에서 사용하기 위해 온오프 식으로 점프를 만들어줌
        jumpT = true;
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJump = true;
    }


    /*    private void CheckGround()
        {   //레이저를 쏴서 바닥인지 체크하는 코드 그리고 공중일 경우 점프했다는 것이기 때문에 점프를 안되게 막아준다.
            //Debug.DrawRay(gameObject.transform.position, Vector3.down * 100, Color.red);
            if (Physics.Raycast(gameObject.transform.position, Vector3.down, distToGround))
            { 
                grounded = true;
                return;
            }
            grounded = false;
            jumpT = false;
        }*/


}
