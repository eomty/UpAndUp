using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSet : MonoBehaviour
{

    public Text scoreText;
    public Text highText;
    public Text highScoreText;
    // Update is called once per frame

    private void Start()
    {   //시작시 PlayerPrefs에 저장된 최고점수를 가져온다.
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.Save();
    }

    void Update()
    {   //UI 텍스트 정리
        scoreText.text = "Score:" + GameManager.score;
        highText.text = "High:" + GameManager.high;
        highScoreText.text = "HighScore:" + GameManager.highScore;
    }
}
