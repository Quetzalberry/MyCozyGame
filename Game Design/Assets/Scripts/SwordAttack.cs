using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Animator SwordAnimator;

    // Start is called before the first frame update
    void Start()
    {
        SwordAnimator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SwordAnimator.SetBool("SwordAttack1", true);
        }

        if (Input.GetKeyUp("space"))
        {
            SwordAnimator.SetBool("SwordAttack1", false);
        }
    }
}
