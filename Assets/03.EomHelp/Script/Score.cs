using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScore;
    //TextMeshPro highScore;
    private int resource;
    //public Text highStair;
    // Start is called before the first frame update
    void Awake()
    {
       // highScore=GetComponent<TextMeshProUGUI>();
        GameManager.highScore = PlayerPrefs.GetInt("HighScore");
        //GameManager.highStair = PlayerPrefs.GetInt("HighStair");
        PlayerPrefs.Save();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //highStair.text = "BestStair:" + GameManager.highStair;
        highScore.text = "BestScore:" + GameManager.highScore;
    }

}
