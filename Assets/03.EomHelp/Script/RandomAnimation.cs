using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
	// Start is called before the first frame update

	public Animator MainSceneAnimator;

    void Start()
    {
		//GameManager.animationNum = 0;
	}

   //  Update is called once per frame
    void Update()
    {


		switch (GameManager.animationNum)
		{
			//case 0:
			//	MainSceneAnimator.SetTrigger("a0");
			//	GameManager.animationNum = 0;
			//	break;
			case 1:
				MainSceneAnimator.SetTrigger("a1");
				GameManager.animationNum = 0;
				break;
			case 2:
				MainSceneAnimator.SetTrigger("a2");
				GameManager.animationNum = 0;
				break;
			case 3:
				MainSceneAnimator.SetTrigger("a3");
				GameManager.animationNum = 0;
				break;
			case 4:
				MainSceneAnimator.SetTrigger("a4");
				GameManager.animationNum = 0;
				break;
			case 5:
				MainSceneAnimator.SetTrigger("a5");
				GameManager.animationNum = 0;
				break;
			case 6:
				MainSceneAnimator.SetTrigger("a6");
				GameManager.animationNum = 0;
				break;
			case 7:
				MainSceneAnimator.SetTrigger("a7");
				GameManager.animationNum = 0;
				break;
			case 8:
				MainSceneAnimator.SetTrigger("a8");
				GameManager.animationNum = 0;
				break;
			case 9:
				MainSceneAnimator.SetTrigger("a9");
				GameManager.animationNum = 0;
				break;
			case 10:
				MainSceneAnimator.SetTrigger("a10");
				GameManager.animationNum = 0;
				break;
			case 11:
				MainSceneAnimator.SetTrigger("a11");
				GameManager.animationNum = 0;
				break;
			case 12:
				MainSceneAnimator.SetTrigger("a12");
				GameManager.animationNum = 0;
				break;
			case 13:
				MainSceneAnimator.SetTrigger("a13");
				GameManager.animationNum = 0;
				break;
			default:
				break;

		}

		}
    }

