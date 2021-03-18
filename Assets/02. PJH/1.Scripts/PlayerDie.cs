using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{

    bool isDie = false;
    public PlayerAnimation MyAnimator;
    public GameObject PopopC;
    public bool isCanDie = true;//점수측정칸에 들어왔는지 체크
    private void Start()
    {
       // MyAnimator.GetComponentInChildren<PlayerAnimation>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isCanDie)
            {
                // Debug.Log(gameObject.transform.eulerAngles);
                Debug.Log("Die");
                //MyAnimator.SetTrigger("Die");
                isDie = true;
                //MyAnimator.DieAnimaion();
                //MyAnimator.DieAnimation();
                Handheld.Vibrate();
                StartCoroutine(WaitResult());
                GameManager.GameDataSave(isDie);

            }
        }
    }



    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(1.5f);
       // PopopC.SetActive(true);

    }
}
