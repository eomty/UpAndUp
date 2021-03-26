using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.reAnimationNum = Random.Range(0, 7); //OTLNum 8
        Debug.Log("reAni: " + GameManager.reAnimationNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
