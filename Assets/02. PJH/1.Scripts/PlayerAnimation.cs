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

	public void GoodAnimation()
	{
		playerAnimator.SetTrigger("Good");
	}

	public void ExcellentAnimation()
	{
		playerAnimator.SetTrigger("Excellent");
	}

	public void PerfactAnimation()
	{
		playerAnimator.SetTrigger("Perfact");
	}

	public void DieAnimation()
	{
		playerAnimator.SetTrigger("Die");
	}

	public void BadAnimation()
	{
		playerAnimator.SetTrigger("Bad");
	}

	//public void JumpAnimaion()
	//{
	//	playerAnimator.SetTrigger("Jump");
	//}

}
