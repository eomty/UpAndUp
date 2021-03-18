using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScore;
    public Text highStair;
    // Start is called before the first frame update
    void Awake()
    {

        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        GameManager.highStair = PlayerPrefs.GetInt("HighStair");
        PlayerPrefs.Save();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        highStair.text = "BestStair:" + GameManager.highStair;
        highScore.text = "BestScore:" + GameManager.highScore;
    }

}
