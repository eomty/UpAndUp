using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
	public GameObject AudioManager;
	AudioSource audio;
	private void Awake()
    {
		AudioManager = GameObject.Find("AudioManager");
		audio = AudioManager.GetComponent<AudioSource>();
		if (audio.isPlaying) return; //배경음악이 재생되고 있다면 패스
		else
		{
			audio.Play();
			DontDestroyOnLoad(AudioManager); //배경음악 계속 재생하게(이후 버튼매니저에서 조작)
		}
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
		GameManager.nextInitHeight = 0;
	}

	public void ToStartScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
		GameManager.high = 0;
		GameManager.score = 0;
		GameManager.Ghigh = 0;
		GameManager.isPlayerDie = false;
		GameManager.scoreNum = 0;
		GameManager.nextInitHeight = 0;
	}
}
