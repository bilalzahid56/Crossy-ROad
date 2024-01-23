using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject stage;
    private Transform player;
    private float start = -381.6f;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("RepeatInstant",20f);
        InvokeRepeating("Destroy", 22f);
    }
    
    // Update is called once per frame
    
    void RepeatInstant()
    {
        start = start - 57;
        Instantiate(stage,new Vector3(start,stage.transform.position.y,stage.transform.position.z),transform.rotation);


    }
    void Destroy()
    {
        Destroy(stage);
    }
}
