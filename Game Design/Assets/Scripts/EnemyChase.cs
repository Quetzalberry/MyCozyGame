using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    public float Speed;

    private float Distance;

    public Animator EnemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        EnemyAnimator.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Player")
        {
            EnemyAnimator.SetTrigger("EnemyAttack");
        }

        if (collision.collider.tag == "Weapon")
        {
            EnemyAnimator.SetBool("EnemyDeath", true);
            Enemy.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, Speed * Time.deltaTime);
    }
}
