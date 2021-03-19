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
    bool isjump = false;
    Rigidbody rig;
    float touchnMoveDistance = 0;
	public PlayerAnimation MyAnimator;

    private void Start()
    {
        rig = player.GetComponent<Rigidbody>();
		MyAnimator =GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();

     
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

        if (isjump ==true && jumpT ==true )
        {
			
            rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
			MyAnimator.JumpAnimaion();
			jumpT = false;
            isjump = false;
        }

     
     


    }

    public void Jump()
    {
        jumpT = true;
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        isjump = true;
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
