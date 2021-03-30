using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    CubeInit cubeInit;
    bool isInit = false;
    private void Start()
    {
        cubeInit = GetComponent<CubeInit>();
        
    }

    private void Update()
    {
        if(isInit == false)
        {
            cubeInit.ObstacleCreate();
            isInit = true;
        }

        
    }

}
