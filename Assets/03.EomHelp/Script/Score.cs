using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    private int score_i;  
    // Start is called before the first frame update
    void Awake()
    {
        
        score_i = 0;
    }
    void Start()
    {
        //score.text = Test_s.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "현재점수:" + score_i.ToString();
    }

    public void AddScore()
    {
        score_i += 1;
        Debug.Log("꺄르륵");
    }
}
