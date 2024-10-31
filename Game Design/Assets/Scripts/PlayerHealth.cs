using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject GameOver;

    public GameObject Player;

    public int Life = 0;

    void Start()
    {
        Player.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Life++;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life == 1)
        {
            heart1.SetActive(false);
        }
        if (Life == 2)
        {
            heart2.SetActive(false);
        }
        if (Life == 3)
        {
            heart3.SetActive(false);
            GameOver.SetActive(true);
            Player.SetActive(false);
        }
    }
}
