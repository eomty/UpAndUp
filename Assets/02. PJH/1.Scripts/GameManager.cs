using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    static public float animationNum = 0;
    static public int high = 0;
    static public int score = 0;
    static public int highScore= 0;
    static public int highStair = 0;
    static public int Ghigh=0;
    static public float nextInitHeight = 0;
    static public bool isPlayerDie = false;
    GoogleAdsManager googleAdsManager;

    private void Start()
    {
        googleAdsManager.ShowBanner();
    }

    public static void GameDataSave(bool isDie)
    {
        if(isDie == true)
        {
            //Debug.Log((PlayerPrefs.GetInt("HighScore")));    임시로 제거함 간결하게
            if (PlayerPrefs.GetInt("HighScore")< score)
            {
                highScore = score;

            }
            if (PlayerPrefs.GetInt("HighStair") < high)
            {
                highStair = high;

            }

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.SetInt("HighStair", highStair);
            PlayerPrefs.Save();
        }
    }

}
