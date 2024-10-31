using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float speedX;
    float speedY;

    public Animator animator;

    Rigidbody2D rb;

    public GameObject Character;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector2(speedX, speedY);

        animator.SetFloat("WalkRight", speedX);
        animator.SetFloat("WalkLeft", -speedX);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Vector3 direction = (transform.position - Character.transform.position).normalized;

            Character.GetComponent<Rigidbody>().AddForce(direction * speed);
        }
    }
}
