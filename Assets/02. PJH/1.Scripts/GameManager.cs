using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{


    static public int high = 0;
    static public int score = 0;
    static public int highScore= 0;
 

    public static void GameDataSave(bool isDie)
    {
        if(isDie == true)
        {
            Debug.Log((PlayerPrefs.GetInt("HighScore")));
            if (PlayerPrefs.GetInt("HighScore")< score)
            {
                highScore = score;

            }

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

}
