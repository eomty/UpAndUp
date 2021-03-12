using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{

    public Slider backVolume;
    public Slider sfxVolume;
    public AudioSource audio;
    public AudioSource audio2;

	// Start is called before the first frame update
	void Start()
	{
		backVolume.onValueChanged.AddListener((value) => { OnBackVolumeValueChanged(value); });
		backVolume.onValueChanged.AddListener(delegate { OnBackVolumeValueChanged(backVolume.value); });
	}

	public void OnBackVolumeValueChanged(float value)
	{
		audio.volume = value * 0.1f;
		PlayerPrefs.SetFloat("backvol", audio.volume);
	}

	public void OnSFXVolumeChanged(float value)
	{
		audio2.volume = value * 0.1f;
		PlayerPrefs.SetFloat("sfxvol", audio2.volume);
	}
}
