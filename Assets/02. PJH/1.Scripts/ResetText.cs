using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetText : MonoBehaviour
{

    public GameObject textList1;
    public GameObject textList2;
    public GameObject textList3;
    public GameObject textList4;
    //AutoDestroyed autoDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 2f);
        //textList1 = GameObject.FindGameObjectWithTag("reset");
        //textList2 = GameObject.FindGameObjectWithTag("reset");
        //textList3 = GameObject.FindGameObjectWithTag("reset");
        //textList4 = GameObject.FindGameObjectWithTag("reset");
        //autoDestroyed.GetComponent<AutoDestroyed>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TextCreate()
    {
        //autoDestroyed.Active1f();
        switch (GameManager.TextNum)
        {
            case 1:
                Instantiate(textList1, new Vector3(0, 800f, 0), Quaternion.identity,
                    GameObject.Find("MainCC").transform);
                break;
            case 2:
                Instantiate(textList2, new Vector3(0, 800f, 0), Quaternion.identity,
                    GameObject.Find("MainCC").transform);
                break;
            case 3:
                Instantiate(textList3, new Vector3(0, 800f, 0), Quaternion.identity,
                    GameObject.Find("MainCC").transform);
                break;
            case 4:
                //Instantiate(textList4, new Vector3(0, 0, 0), Quaternion.identity,
                    //GameObject.Find("Canvas").transform);
                break;
        }

    }

}