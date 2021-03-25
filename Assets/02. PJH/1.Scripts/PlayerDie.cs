using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{


    public GameObject PopopC;
	public GameObject MainC;
	public GameObject ResultCharacter;
    public bool isCanDie;
    private void Start()
    {
        //PopopC = GameObject.FindWithTag("PopopC");
        MainC = GameObject.FindWithTag("MainC");
        //ResultCharacter = GameObject.FindWithTag("ResultPlayer");
       ResultCharacter = GameObject.FindWithTag("ResultPlayer").transform.Find("ResultPlayer2").gameObject;
       PopopC = GameObject.FindWithTag("PopupC").transform.Find("Popup").gameObject;
        //playAnimation = GameObject.FindWithTag("Model").GetComponent<PlayerAnimation>();
    }


    public void CallDie()
    {
        if (GameManager.isPlayerDie == false)
        {
            GameManager.isPlayerDie = true;
           
            Debug.Log("Die");

               MainC.SetActive(false);
            
            //DC.Delete();


             Handheld.Vibrate();
            StartCoroutine(WaitResult());
            GameManager.GameDataSave(GameManager.isPlayerDie);


        }


    }



    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(1.5f);
        PopopC.SetActive(true);
        ResultCharacter.SetActive(true);

    }
}
