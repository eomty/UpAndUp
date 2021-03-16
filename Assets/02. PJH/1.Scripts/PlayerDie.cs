using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
   
    bool isDie = false;
    GameManager GM;
	public Animator animator;
    private void Start()
    {
		animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(isDie == false)
        {
            if (gameObject.transform.eulerAngles.x < -50 ||
                (gameObject.transform.eulerAngles.x<310 && gameObject.transform.eulerAngles.x > 50) ||
                (gameObject.transform.eulerAngles.z  < 310 && gameObject.transform.eulerAngles.z > 50) ||
                gameObject.transform.eulerAngles.z < -50)
             {
                Debug.Log(gameObject.transform.eulerAngles);
                Debug.Log("Die");
				animator.SetTrigger("Die");
				isDie = true;
				animator.SetTrigger("Die");
				GameManager.GameDataSave(isDie);
             }
        }
           

        
        
    }

}
