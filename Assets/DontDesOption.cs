using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesOption : MonoBehaviour
{
	public static DontDesOption Instance;
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
