using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove2 : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        new Vector3(-6.5f, 0, 69.9f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
        if (transform.position.z < -53 )
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 69.9f);
        }
    }
}
