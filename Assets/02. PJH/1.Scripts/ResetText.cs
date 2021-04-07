using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetText : MonoBehaviour
{

    public GameObject textList1;
    public GameObject textList2;
    public GameObject textList3;
    //AutoDestroyed autoDestroyed;
    // Start is called before the first frame update
    public void TextCreate()
    {
        Invoke("SC", 0.1f);
        //autoDestroyed.Active1f();
    }
    public void SC()
    {
        switch (GameManager.TextNum)
        {
            case 1:
                textList1.SetActive(true);
                break;
            case 2:
                textList2.SetActive(true);
                break;
            case 3:
                textList3.SetActive(true);
                break;
            case 4:
                Debug.Log("CASE4 DIE");
                break;

        }

		//if (gameObject.activeSelf == true)
		//{
			
		//	StartCoroutine("WaitResult");
		//}
		//else
		//{
		//	Debug.Log("false");
		//}

    }

    //IEnumerator WaitResult()
    //{

    //    yield return new WaitForSeconds(2f);
    //    textList1.SetActive(false);
    //    textList2.SetActive(false);
    //    textList3.SetActive(false);
    //}

}