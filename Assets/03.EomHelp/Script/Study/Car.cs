using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
	public string carName = "car";

	public void Go()
	{
		Debug.Log($"{carName}이 출발~~~");
	}
}