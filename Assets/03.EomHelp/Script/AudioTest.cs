using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
	// Start is called before the first frame update

	public AudioSource audioSource;
	public AudioClip bgm;
   public void Start()
     {
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = bgm;
		audioSource.volume = 1.0f;
		audioSource.loop = true;
		audioSource.mute = false;
		audioSource.Play();
		audioSource.Stop();

		audioSource.playOnAwake = true;



	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
