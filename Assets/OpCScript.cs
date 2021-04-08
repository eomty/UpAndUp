using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpCScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject OpC;
    void Start()
    {
        OpC = GameObject.Find("btnOptionC");
        OpC.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
