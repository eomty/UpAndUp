using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text Cs_score;
    public Text Cs_stair;
    public Text Best_score;
    public Text Best_stair;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        GameManager.highStair = PlayerPrefs.GetInt("HighStair");
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        Cs_score.text = "CurrentScore:" + GameManager.score;
        Cs_stair.text = "CurrentStair:" + GameManager.high;
        Best_score.text = "BestScore:" + GameManager.highScore;
        Best_stair.text = "BestStair:" + GameManager.highStair;
    }
}
