using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSet : MonoBehaviour
{

    public Text scoreText;
    public Text highText;
    public Text highScoreText;
    public Text scoreX;
    // Update is called once per frame

    private void Start()
    {
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.Save();
    }

    void Update()
    {
        scoreText.text = "Score:" + GameManager.score;
        highText.text = "Stair:" + GameManager.high;
        highScoreText.text = "HighScore:" + GameManager.highScore;
        scoreX.text = (GameManager.scoreNum + " X " + GameManager.high);
    }
}
