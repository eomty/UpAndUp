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
    public Text scoreX2;
    public Text scoreX3;
    // Update is called once per frame

    private void Start()
    {
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.Save();
        //scoreX.color = new Color(255 / 255f, 10 / 255f, 10 / 255f, 255 / 255f);
    }

    void Update()
    {
        scoreText.text = "Score:" + GameManager.score;
        highText.text = "Stair:" + GameManager.high;
        highScoreText.text = "HighScore:" + GameManager.highScore;
        scoreX.text = GameManager.scoreNum + " X " + GameManager.high;
        scoreX2.text = GameManager.scoreNum + " X " + GameManager.high;
        scoreX3.text = GameManager.scoreNum + " X " + GameManager.high;
    }
}
