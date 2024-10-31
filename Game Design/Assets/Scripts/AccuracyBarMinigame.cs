using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccuracyBarMinigame : MonoBehaviour
{
    public float speed;

    private bool moveRight = true;

    private int LeftOrRight = 1;

    void Start()
    {

    }

    void Update()
    {
        if (LeftOrRight == 1)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (LeftOrRight == -1)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {
            LeftOrRight = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LeftOrRight = LeftOrRight * -1;
    }
}
