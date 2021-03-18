using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInit : MonoBehaviour
{
    public List<GameObject> obstacleList;
    public GameObject thisCube;
    public GameObject initCube;
 
    bool isInit;
    int initCubeNum;

    private void Awake()
    {
       
        isInit = false;
    }


    public void ObstacleCreate()
    {
        float cubeHeight = thisCube.GetComponent<MeshRenderer>().bounds.size.y;

        float xRange = Random.Range(-8, 8); //생성 범위
        float zRange = Random.Range(7, 12);
        GameManager.nextInitHeight += cubeHeight;
        // Debug.Log(GameManager.nextInitHeight);
        Instantiate(obstacleList[initCubeNum], new Vector3(xRange, GameManager.nextInitHeight + 0.1f, zRange),
            Quaternion.Euler(Quaternion.identity.x, Random.Range(0, 360), Quaternion.identity.z));

    }


}
