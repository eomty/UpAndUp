using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
	// Start is called before the first frame update

	public Animator MainSceneAnimator;

	public float r;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		r= Random.Range(0, 12);
		Debug.Log(r);

		switch (r)
		{
			case 0:
				MainSceneAnimator.SetTrigger("a0");
				break;
			case 1:
				MainSceneAnimator.SetTrigger("a1");
				break;
			case 2:
				MainSceneAnimator.SetTrigger("a2");
				break;
			case 3:
				MainSceneAnimator.SetTrigger("a3");
				break;
			case 4:
				MainSceneAnimator.SetTrigger("a4");
				break;
			case 5:
				MainSceneAnimator.SetTrigger("a5");
				break;
			case 6:
				MainSceneAnimator.SetTrigger("a6");
				break;
			case 7:
				MainSceneAnimator.SetTrigger("a7");
				break;
			case 8:
				MainSceneAnimator.SetTrigger("a8");
				break;
			case 9:
				MainSceneAnimator.SetTrigger("a9");
				break;
			case 10:
				MainSceneAnimator.SetTrigger("a10");
				break;
			case 11:
				MainSceneAnimator.SetTrigger("a11");
				break;
			case 12:
				MainSceneAnimator.SetTrigger("a12");
				break;
			default:
		break;

		}
    }
}
