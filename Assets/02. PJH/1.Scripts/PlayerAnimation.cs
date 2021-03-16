using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	public Animator playerAnimator;

	public void JumpAnimaion()
	{
		playerAnimator.SetTrigger("Jump");
	}

}
