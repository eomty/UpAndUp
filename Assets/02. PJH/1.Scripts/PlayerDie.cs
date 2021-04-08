﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{

    GameObject OpC;
    public GameObject PopopC;
	//public GameObject MainCC;
    public GameObject MainC;
    //public GameObject ResultCharacter;
    public bool isCanDie;
    CameraMovement cameraMove;
    public GameObject player;
    private void Start()
    {
        //PopopC = GameObject.FindWithTag("PopopC");
        //MainCC = GameObject.FindWithTag("MainCC").transform.Find("MainC").gameObject;
        MainC = GameObject.FindWithTag("MainCC");
        //ResultCharacter = GameObject.FindWithTag("ResultPlayer");
        //ResultCharacter = GameObject.FindWithTag("ResultPlayer").transform.Find("ResultPlayer2").gameObject;
        PopopC = GameObject.FindWithTag("PopupC").transform.Find("Popup").gameObject;
        //playAnimation = GameObject.FindWithTag("Model").GetComponent<PlayerAnimation>();
        cameraMove = GameObject.FindWithTag("MainCamera").GetComponent<CameraMovement>();
        OpC = GameObject.Find("btnOptionC");
    }


    public void CallDie()
    {
        if (GameManager.isPlayerDie == false)
        {
            GameManager.isPlayerDie = true;

            //Debug.Log("Die");
            //cubemove.playerOn2 = true;
            //cubemove.DontMove();
               MainC.SetActive(false);
            OpC.SetActive(false);
            //DC.Delete();


             Handheld.Vibrate();
            StartCoroutine(WaitResult());
            GameManager.GameDataSave(GameManager.isPlayerDie);


        }


    }



    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(0.5f);
        PopopC.SetActive(true);
        //ResultCharacter.SetActive(true);
        //cameraMove.GameEndCameraPosition();
    }
}
