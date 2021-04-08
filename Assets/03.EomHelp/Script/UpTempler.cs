using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpTempler : MonoBehaviour
{
    public float speed = 0f;
    public GameObject SetUI;
    // Start is called before the first frame update
    void Start()
    {
		Invoke("UpStart", 1f);
	}

	public void UpStart()
	{
		speed = 25f;
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = 0f;
        SetUI.SetActive(true);
    }

    IEnumerator MainScene()
    {
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadScene("MainScene");
    }

}