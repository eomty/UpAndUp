using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FS_Player : MonoBehaviour
{
	public Rigidbody rig;
	float jumpPower = 0;
	public float RoSpeed = 20f;
	public Transform from;
	public Transform to;

	// Start is called before the first frame update
	void Start()
    {
		jumpPower = 700f;
		Invoke("PlayerFS", 0.5f);
	}

	public void PlayerFS()
	{
		//rig.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
		rig.AddForce(0, 12.5f, 0 * Time.deltaTime,ForceMode.Impulse);
		//Invoke("PlayerRotate", 3f);
		//StartCoroutine("WaitResult");
	}

	// Update is called once per frame
	void Update()
    {

		//rig.rotation = Quaternion.Slerp(from.rotation, to.rotation, Time.time * RoSpeed);
	}
}
