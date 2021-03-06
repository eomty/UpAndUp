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
    Music soundSet;

    private void Start()
    {
        rig = player.GetComponent<Rigidbody>();
		MyAnimator = GetComponentInChildren<PlayerAnimation>();
        soundSet = GameObject.Find("AudioManager").GetComponent<Music>();
    }

    private void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (isjump && isGround() &&GameManager.isPlayerDie == false)
                    {
                        MyAnimator.SitAnimation();
                    }
                    break;

                case TouchPhase.Moved:
                    Vector3 moveDistance = Input.GetTouch(0).deltaPosition;
                    touchnMoveDistance += moveDistance.y;
                    break;

                case TouchPhase.Ended:
                    if (touchnMoveDistance <= 500)
                    {
                        touchnMoveDistance = 600;
                    }
                    else if (touchnMoveDistance >= 850)
                    {
                        touchnMoveDistance = 850;
                    }
                    jumpPower = touchnMoveDistance;
                    Jump();
                    //GameManager.TextNum = 0;
                    touchnMoveDistance = 0;
                    break;
            }

        }
    }
    private void FixedUpdate()
    {
        

        if (isjump && jumpT && isGround() && GameManager.isPlayerDie== false)
        {

            soundSet.JumpSoundChange();

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
    
    public bool isGround()
    {  
        return Physics.Raycast(transform.position, Vector3.down, distToGround, rayLayerMask);
    }

}
