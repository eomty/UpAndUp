using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{

    public GameObject textList1;
    public GameObject textList2;
    public GameObject textList3;
    //AutoDestroyed autoDestroyed;
    // Start is called before the first frame update
    public void TextCreate2()
    {
        //Invoke("SC", 0.8f);
        StartCoroutine("WaitForDestroy");
        //autoDestroyed.Active1f();
    }
    public void SC()
    {
        
    }

    IEnumerator WaitForDestroy()
    {

        yield return new WaitForSeconds(0.7f);
        switch (GameManager.TextNum)
        {
            case 1:
                textList1.SetActive(false);
                break;
            case 2:
                textList2.SetActive(false);
                break;
            case 3:
                textList3.SetActive(false);
                break;

        }
        //    textList1.SetActive(false);
        //    textList2.SetActive(false);
        //    textList3.SetActive(false);
    }

}