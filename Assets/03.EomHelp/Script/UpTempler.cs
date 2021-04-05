using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpTempler : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = 0f;
        StartCoroutine("MainScene");
    }

    IEnumerator MainScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainScene");
    }

}