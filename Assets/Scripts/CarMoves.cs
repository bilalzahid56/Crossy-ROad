using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoves : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
        if(transform.position.z > 70f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -53f);
        }
    }
}
