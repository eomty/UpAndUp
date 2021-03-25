using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScriptReset : StateMachineBehaviour
{
    public GameObject reset1;
    public GameObject reset2;
    public GameObject reset3;
    public GameObject reset4;

    private void Awake()
    {
        //reset2.GetComponent<ResetText>();
        
    }
    private void OnStateExit()
    {
        reset1.transform.position = Vector3.zero;
        reset2.transform.position = Vector3.zero;
        reset3.transform.position = Vector3.zero;
        reset4.transform.position = Vector3.zero;
        Debug.Log("씨발");
    }

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
