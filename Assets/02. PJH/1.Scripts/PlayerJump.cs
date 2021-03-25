using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerJump : MonoBehaviour//, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public float jumpPower = 0;
    public float distToGround = 0.6f;
    bool grounded = false;
    bool jumpT = false;
    bool isjump = false;
    Rigidbody rig;
    float touchnMoveDistance = 0;
	public PlayerAnimation MyAnimator;

    //public void IPointerDownHandler()
    //{
        
    //}
    private void Start()
    {
        rig = player.GetComponent<Rigidbody>();
		MyAnimator = GetComponentInChildren<PlayerAnimation>();
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
            if(touchnMoveDistance<= 500)
            {
                touchnMoveDistance = 500;
            }
            else if(touchnMoveDistance >= 700)
            {
                touchnMoveDistance = 700;
            }

            jumpPower = touchnMoveDistance;
            Jump();
            GameManager.TextNum = 0;

            touchnMoveDistance = 0;
        }

        if (isjump ==true  && jumpT)
        {
			
            rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
			MyAnimator.JumpAnimaion();
            isjump = false;
            jumpT = false;

        }

  
    }

    public void Jump()
    {
        if(isjump)
        {
            jumpT = true;
        }



      
    }
    private void OnCollisionEnter(Collision collision)
    {
        isjump = true;
    }

    public void SitDown()
    {
        MyAnimator.SitAnimation();
    }


}
