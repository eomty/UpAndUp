using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 500f;
    public float y = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime * speed *20;
        transform.rotation = Quaternion.Euler(0, y, 0);
    }
}
