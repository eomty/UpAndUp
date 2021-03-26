using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReRandomAnimation : MonoBehaviour
{
	// Start is called before the first frame update

	public Animator ReAnimator;
	//public GameObject mainCha;

	//  Update is called once per frame
	void Update()
	{

		//public class RandomAnimation : MonoBehaviour//

		switch (GameManager.reAnimationNum)
		{
			//case 0:
			//	MainSceneAnimator.SetTrigger("a0");
			//	GameManager.animationNum = 0;
			//	break;
			case 0:
				ReAnimator.SetTrigger("d");
				GameManager.reAnimationNum = 10;
				//mainCha.transform.rotation = Quaternion.Euler(0, 90f, 0);
				break;
			case 1:
				ReAnimator.SetTrigger("d0");
				GameManager.reAnimationNum = 10;
				break;
			case 2:
				ReAnimator.SetTrigger("d1");
				GameManager.reAnimationNum = 10;
				break;
			case 3:
				ReAnimator.SetTrigger("d2");
				GameManager.reAnimationNum = 10;
				break;
			case 4:
				ReAnimator.SetTrigger("d3");
				GameManager.reAnimationNum = 10;
				break;
			case 5:
				ReAnimator.SetTrigger("d4");
				GameManager.reAnimationNum = 10;
				break;
			case 6:
				ReAnimator.SetTrigger("d5");
				GameManager.reAnimationNum = 10;
				break;
			case 7:
				ReAnimator.SetTrigger("OTL");
				GameManager.reAnimationNum = 10;
				break;
		
			default:
				break;

		}

	}
}


