using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioClip maintheme;
    public AudioClip menutheme; 
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayMusic(menutheme,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.PlayMusic(maintheme, 3);
        }
    }
}
