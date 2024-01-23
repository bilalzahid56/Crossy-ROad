using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    [SerializeField] private Text score;
    private int destroyCoins = 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            destroyCoins++;
            score.text = "Coins : " + destroyCoins;
        }
    }
}
