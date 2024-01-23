using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text score;
    private int destroyCoins = 0;
    public float speed = 1;
    public Rigidbody rb;
    public float force;
    private Vector3 rot = new Vector3(0, 0, 0);
    public bool istrue = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

  
    void Update()
    {
        float horizX = Input.GetAxis("Horizontal");
        float vecticalY = Input.GetAxis("Vertical");

        transform.Translate(horizX*Vector3.right*speed);
        transform.Translate(vecticalY * Vector3.forward * speed);
        if(Input.GetKeyDown(KeyCode.Space) && istrue)
        {
            istrue = false;
            rb.AddForce(Vector3.up*force);
            Invoke("repeat", 0.5f);
        }
      
    }
    void repeat()
    {
        Debug.Log("ff");
        istrue = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("CAR"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Water"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Truck"))
        {
            SceneManager.LoadScene(0);
        }
        if(collision.gameObject.CompareTag("Coin"))
        {
            destroyCoins++;
            score.text = "Coins : " + destroyCoins;
        }
    }
}
