using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesOption2 : MonoBehaviour
{
	public static DontDesOption2 Instance;
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
	}
}

