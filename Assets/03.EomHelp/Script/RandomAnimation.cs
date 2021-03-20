using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
	// Start is called before the first frame update

	public Animator animator;

	public float r;
	public bool loop;

	private void Awake()
	{
		r = 20;
	}
}
//    void Start()
//    {

//		switch (r)
//		{


//			case 0:
//				animator.SetTrigger("a0");
//				break;
//			case 1:
//				animator.SetTrigger("a1");
//				break;
//			case 2:
//				animator.SetTrigger("a2");
//				break;
//			case 3:
//				animator.SetTrigger("a3");
//				break;
//			case 4:
//				animator.SetTrigger("a4");
//				break;
//			case 5:
//				animator.SetTrigger("a5");
//				break;
//			case 6:
//				animator.SetTrigger("a6");
//				break;
//			case 7:
//				animator.SetTrigger("a7");
//				break;
//			case 8:
//				animator.SetTrigger("a8");
//				break;
//			case 9:
//				animator.SetTrigger("a9");
//				break;
//			case 10:
//				animator.SetTrigger("a10");
//				break;
//			case 11:
//				animator.SetTrigger("a11");
//				break;
//			case 12:
//				animator.SetTrigger("a12");
//				break;
//			case 20:
//				animator.SetTrigger("a20");
//				break;
//			default:
//				break;
//				//}
//		}
//		//loop = true;
//		//r = Random.Range(0, 12);
//	}
//	// Update is called once per frame
//	void Update()
//    {

//		//r= Random.Range(0, 12);
//		//Debug.Log(r);

//		//while (loop == true) {
			
//    }
//}
