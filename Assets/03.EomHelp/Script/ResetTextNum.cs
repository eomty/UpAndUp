using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTextNum : MonoBehaviour
{

    public GameObject textList1;
    public GameObject textList2;
    public GameObject textList3;

    // Start is called before the first frame update

    //private void Start()
    //{
    //    Destroy(this.gameObject, 2.5f);
    //}
    public void TextScoreCreate()
    {
        Invoke("SC", 1f);
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
        }
        Debug.Log("sasd");
        StartCoroutine("WaitResult");
    }

    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(1f);
        textList1.SetActive(false);
        textList2.SetActive(false);
        textList3.SetActive(false);
    }

}
