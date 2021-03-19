using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{

    bool isDie = false;
    GameManager GM;
    public PlayerAnimation MyAnimator;
    public GameObject PopopC;
	public GameObject MainC;
	private DeleteCanvas DC;
	public GameObject ResultCharacter;
    private void Start()
    {
        MyAnimator.GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isDie == false)
        {
            if (gameObject.transform.eulerAngles.x < -50 ||
                (gameObject.transform.eulerAngles.x < 310 && gameObject.transform.eulerAngles.x > 50) ||
                (gameObject.transform.eulerAngles.z < 310 && gameObject.transform.eulerAngles.z > 50) ||
                gameObject.transform.eulerAngles.z < -50)
            {
                Debug.Log(gameObject.transform.eulerAngles);
                Debug.Log("Die");
                //MyAnimator.SetTrigger("Die");
                isDie = true;
                //MyAnimator.DieAnimaion();
                MyAnimator.DieAnimation();
				MainC.SetActive(false);
				ResultCharacter.SetActive(true);
				//DC.Delete();

		
                Handheld.Vibrate();
                StartCoroutine(WaitResult());
                GameManager.GameDataSave(isDie);

            }
        }




    }
    IEnumerator WaitResult()
    {

        yield return new WaitForSeconds(1.5f);
        PopopC.SetActive(true);

    }
}
