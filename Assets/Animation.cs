using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : StateMachineBehaviour
{
	private Animator animator;

	public float r;
	public bool loop;
    internal object clip;

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
       
	{
		//loop = true;
		r = Random.Range(0, 12);
		Debug.Log(r);
	
	// Update is called once per frame
	
		//while (loop == true) {
		switch (r)
		{
			case 0:
				animator.SetTrigger("a0");
				break;
			case 1:
				animator.SetTrigger("a1");
				break;
			case 2:
				animator.SetTrigger("a2");
				break;
			case 3:
				animator.SetTrigger("a3");
				break;
			case 4:
				animator.SetTrigger("a4");
				break;
			case 5:
				animator.SetTrigger("a5");
				break;
			case 6:
				animator.SetTrigger("a6");
				break;
			case 7:
				animator.SetTrigger("a7");
				break;
			case 8:
				animator.SetTrigger("a8");
				break;
			case 9:
				animator.SetTrigger("a9");
				break;
			case 10:
				animator.SetTrigger("a10");
				break;
			case 11:
				animator.SetTrigger("a11");
				break;
			case 12:
				animator.SetTrigger("a12");
				break;
			default:
				break;
				//}
		}
	}

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
