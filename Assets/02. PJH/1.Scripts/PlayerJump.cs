using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerJump : MonoBehaviour//, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public float jumpPower = 0;
    public float distToGround = 2f;
    bool jumpT = false;
    bool isjump = false;
   public Rigidbody rig;
    float touchnMoveDistance = 0;
	public PlayerAnimation MyAnimator;
    public LayerMask rayLayerMask;

  
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
            //GameManager.reAnimationNum = Random.Range(0, 7);
           // Debug.Log("reAni: " + GameManager.reAnimationNum);
            GameManager.TextNum = 0;

            touchnMoveDistance = 0;
        }

        if (isjump && jumpT && isGround())
        {
		    
            rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
			MyAnimator.JumpAnimaion();
            //GameManager.reAnimationNum = Random.Range(0, 7);
            //Debug.Log("reAni: " + GameManager.reAnimationNum);
            isjump = false;
            jumpT = false;
            
        }

  
    }

    public void Jump()
    {
        if(isjump)
        {
            jumpT = true;
            //player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotation;
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
    
    public bool isGround()
    {  
        return Physics.Raycast(transform.position, Vector3.down, distToGround, rayLayerMask);
    }

}
