using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{


    static public int high = 0;
    static public int score = 0;
    static public int highScore= 0;
    static public int highStair = 0;
    static public int GHigh=0;


    // void Update()
    //{
    //    GScore = score;
    //    GHigh = high;

    //}
    public static void GameDataSave(bool isDie)
    {
        if(isDie == true)
        {
            Debug.Log((PlayerPrefs.GetInt("HighScore")));
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
