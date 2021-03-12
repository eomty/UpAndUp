using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update

    bool IsPause;
    void Start()
    {
        IsPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //Time.timeScale =2 로함녀 2배로 빨리감.
        {
            if (IsPause == false)
            {
                Time.timeScale = 0;
                IsPause = true;
                return;
            }

            if (IsPause == true)
            {
                Time.timeScale = 1;
                IsPause = false;
                return;
            }
        }
    }
    }

