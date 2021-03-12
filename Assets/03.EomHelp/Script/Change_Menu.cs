using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Menu : MonoBehaviour
{
    public GameObject Option_C;
    public GameObject Main_C;

    public Slider[] volumeSliders;
    public AudioClip test1;

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
        Main_C.SetActive(false);
        Option_C.SetActive(true);
    }

    public void MainMenu()
    {
        Main_C.SetActive(true);
        Option_C.SetActive(false);
    }

    public void TestSound()
    {
        AudioManager.instance.PlaySound(test1, transform.position);
    }

    public void SetMasterVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Master);
    }

    public void SetMusicVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Music);
    }

    public void SetSfxVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Sfx);
    }
}
