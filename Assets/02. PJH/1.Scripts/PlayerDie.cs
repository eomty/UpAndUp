using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{


    //public PlayerAnimation MyAnimator;
    //public GameObject PopopC;
	//public GameObject MainC;
	//public GameObject ResultCharacter;
    public bool isCanDie;
    private void Start()
    {
        //MyAnimator.GetComponentInChildren<PlayerAnimation>();
    }


    public void CallDie()
    {
        if (GameManager.isPlayerDie == false)
        {
            GameManager.isPlayerDie = true;
            Debug.Log(gameObject.transform.eulerAngles);
            Debug.Log("Die");
            //MyAnimator.SetTrigger("Die");
            //MyAnimator.DieAnimaion();
            //MyAnimator.DieAnimation();
            //MainC.SetActive(false);
           // ResultCharacter.SetActive(true);
            //DC.Delete();


            Handheld.Vibrate();
            StartCoroutine(WaitResult());
            GameManager.GameDataSave(GameManager.isPlayerDie);


        }


    }



    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(1.5f);
        //PopopC.SetActive(true);

    }
}
