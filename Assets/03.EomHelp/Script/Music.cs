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
	public AudioClip[] sfxClip;

	public static Music Instance;
	void Start()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}

		Instance = this;
		//DontDestroyOnLoad(gameObject);
	


		DontDestroyOnLoad(transform.gameObject);
		//audio2 = this.GetComponent<AudioSource>();

		audio.volume = 0.5f;   //배경음악
		audio2.volume = 0.5f; //효과음

		backVolume.onValueChanged.AddListener((value) =>
		{ OnBackVolumeValueChanged(value); });
		sfxVolume.onValueChanged.AddListener(delegate
		{ OnSFXVolumeChanged(sfxVolume.value); });

		//StartCoroutine("PlayList");
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

public void JumpSoundChange()
    {
		//audio2.clip = sfxClip[0];
		audio2.PlayOneShot(sfxClip[0]);
	}
	public void DieSoundChange()
	{
		//audio2.clip = sfxClip[1];
		audio2.PlayOneShot(sfxClip[1]);
	}
	public void PerfectSoundChange()
	{
		//audio2.clip = sfxClip[2];
		audio2.PlayOneShot(sfxClip[2]);
	}
	public void ExcellentSoundChange()
	{
		//audio2.clip = sfxClip[3];
		audio2.PlayOneShot(sfxClip[3]);
	}
	public void GoodSoundChange()
	{
		//audio2.clip = sfxClip[4];
		audio2.PlayOneShot(sfxClip[4]);
	}
}
