﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum AudioChannel { Master, Sfx, Music}

    public float masterVolumePercent { get; private set; }
    public float sfxVolumePercent { get; private set; }
    public float musicVolumePercent { get; private set; }

	public AudioClip _jumpSound;
	AudioSource myAudio; //sfx2D



    AudioSource sfx2DSource;
    AudioSource[] musicSources;
    int activeMusicSourceIndex;

    public static AudioManager instance;

    Transform audioListener;
    Transform playerT;

    SoundLibrary library;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            library = GetComponent<SoundLibrary>();
			myAudio = GetComponent<AudioSource>(); //마이 오디오에 컴퍼넌트에 있는 오디오 서스넣기 2fx

            musicSources = new AudioSource[2];
            for (int i = 0; i < 2; i++)
            {
                GameObject newMusicSource = new GameObject("Music source" + (i + 1));
                musicSources[i] = newMusicSource.AddComponent<AudioSource>();
                newMusicSource.transform.parent = transform;
            }
            GameObject newSfx2Dsource = new GameObject("2D sfx source");
            sfx2DSource = newSfx2Dsource.AddComponent<AudioSource>();
            newSfx2Dsource.transform.parent = transform;

            audioListener = FindObjectOfType<AudioListener>().transform;
            if(FindObjectOfType<Player>()!= null)
                {
                playerT = FindObjectOfType<Player>().transform;
            }
            /////////////////
            masterVolumePercent = PlayerPrefs.GetFloat("master vol", 1);
            sfxVolumePercent = PlayerPrefs.GetFloat("sfx vol", 1);
            musicVolumePercent = PlayerPrefs.GetFloat("music vol", 1);
                
            }
        }

	public void PlaySound2()
	{
		myAudio.PlayOneShot(_jumpSound);
	}
    void Update()
    {
        if(playerT != null)
        {
            audioListener.position = playerT.position;
        }
    }

    public void SetVolume(float volumePercent, AudioChannel channel)
    {
        switch (channel)
        {
            case AudioChannel.Master:
                masterVolumePercent = volumePercent;
                break;

            case AudioChannel.Sfx:
                sfxVolumePercent = volumePercent;
                break;
            case AudioChannel.Music:
                musicVolumePercent = volumePercent;
                break;
        }
        musicSources[0].volume = musicVolumePercent * masterVolumePercent;
        musicSources[1].volume = musicVolumePercent * masterVolumePercent;

        PlayerPrefs.SetFloat("master vol", masterVolumePercent);
        PlayerPrefs.SetFloat("sfx vol", sfxVolumePercent);
        PlayerPrefs.SetFloat("music vol", musicVolumePercent);


    }

    public void PlayMusic(AudioClip clip, float fadeDuration = 1)
    {
        activeMusicSourceIndex = 1 - activeMusicSourceIndex;
        musicSources[activeMusicSourceIndex].clip = clip;
        musicSources[activeMusicSourceIndex].Play();
        StartCoroutine(AnimateMusicCrossfade(fadeDuration));
    }

    public void PlaySound(AudioClip clip, Vector3 pos)
    {
        if (clip != null)
        {
            try
            {
                AudioSource.PlayClipAtPoint(clip, pos, sfxVolumePercent * masterVolumePercent);
   
            }catch (NullReferenceException e)
            {
   
            }
            }
    }
 

        public void PlaySound(string soundName, Vector3 pos)
        {
            PlaySound(library.GetClipFromName(soundName), pos);
        Debug.Log("여기서뭐함?ㅋㅋ");
        }

    public void PlaySound2D(string soundName)
    {
        sfx2DSource.PlayOneShot(library.GetClipFromName(soundName),
            sfxVolumePercent * masterVolumePercent);
    }

    IEnumerator AnimateMusicCrossfade(float duration)
    {
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime * 1 / duration;
            musicSources[activeMusicSourceIndex].volume = 
                Mathf.Lerp(0, musicVolumePercent * masterVolumePercent,percent);
            musicSources[1 - activeMusicSourceIndex].volume = Mathf.Lerp(musicVolumePercent *
                masterVolumePercent, 0, percent);
            yield return null;


        }
    }
    }


    // Update is called once per frame


