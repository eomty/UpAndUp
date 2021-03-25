using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{

    private void Awake()
    {
        
    }
    public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
		Debug.Log($"Loading scene : {sceneName}");
	}

	public void RetryScene()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		GameManager.high = 0;
		GameManager.score = 0;
		GameManager.Ghigh= 0;
		GameManager.isPlayerDie = false;
		GameManager.scoreNum = 0;
	}

	public void ToStartScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
		GameManager.high = 0;
		GameManager.score = 0;
		GameManager.Ghigh = 0;
		GameManager.isPlayerDie = false;
		GameManager.scoreNum = 0;
	}
}
