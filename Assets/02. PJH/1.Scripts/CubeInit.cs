using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInit : MonoBehaviour
{

    public List<GameObject> obstacleList;
    public GameObject thisCube;
    public GameObject initCube;
    CubeMove CM;
    bool isInit;
    int initCubeNum;
   

    private void Awake()
    {
        initCubeNum = Random.Range(0, obstacleList.Count);

        CM = thisCube.GetComponent<CubeMove>();
        isInit = false;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"&& isInit ==false)
        {
            float cubeHeight = thisCube.GetComponent<MeshRenderer>().bounds.size.y;
            Debug.Log(thisCube.GetComponent<MeshRenderer>().bounds.size.y);
            CM.playerOn = true; //장애물의 움직임을 끄는 코드
            float xRange = Random.Range(-8,8); //생성 범위
            float zRange = Random.Range(7, 12);
            GameManager.nextInitHeight += cubeHeight;
            Debug.Log(GameManager.nextInitHeight);
            Instantiate(obstacleList[initCubeNum], new Vector3( xRange, GameManager.nextInitHeight+ 0.1f, zRange), 
                Quaternion.Euler(Quaternion.identity.x, Random.Range(0,360) ,Quaternion.identity.z));

          

            GameManager.high += 1;//높이 추가

            isInit = true;

        }
        
    }
}
