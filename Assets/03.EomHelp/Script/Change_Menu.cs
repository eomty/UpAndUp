using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Menu : MonoBehaviour
{
    public GameObject Option_C;
    //public GameObject Set_C;
    //public GameObject Start_Btn;

    public GameObject image;
	public GameObject options;

    // Start is called before the first frame update
    void Start()
    {
        /*
        volumeSliders[0].value = AudioManager.instance.masterVolumePercent;
        volumeSliders[1].value = AudioManager.instance.musicVolumePercent;
        volumeSliders[2].value = AudioManager.instance.sfxVolumePercent;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OptionMenu()
    {
        //Set_C.SetActive(false);
        Option_C.SetActive(true);
		Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        //Set_C.SetActive(true);
        Option_C.SetActive(false);
		Time.timeScale = 1f;
    }

    public void Developer()
    {
        image.SetActive(true);
		//options.SetActive(false);
        //Start_Btn.SetActive(false);
        //Option_C.SetActive(false);
    }

    public void Close()
    {
        //Start_Btn.SetActive(true);
        //Option_C.SetActive(true);
        image.SetActive(false);
		options.SetActive(true);
    }

    //public void TestSound()
    //{
    //    AudioManager.instance.PlaySound(test1, transform.position);
    //}

    //public void SetMasterVolume(float value)
    //{
    //    AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Master);
    //}

    //public void SetMusicVolume(float value)
    //{
    //    AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Music);
    //}

    //public void SetSfxVolume(float value)
    //{
    //    AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Sfx);
    //}

}
