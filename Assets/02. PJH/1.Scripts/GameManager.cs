using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    //점수들
    static public int high = 0;
    static public int score = 0;
    static public int highScore= 0;
    static public float nextInitHeight = 0;
 

    //플레이어가 죽을 경우 최고점수르 갱신하는 코드
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
