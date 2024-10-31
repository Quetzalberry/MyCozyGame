using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressingMinigae : MonoBehaviour
{
    public GameObject R;
    public GameObject L;
    public GameObject C;
    public GameObject H;
    public GameObject O;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            R.SetActive(false);
        }

        if (Input.GetKeyDown("l"))
        {
            L.SetActive(false);
        }

        if (Input.GetKeyDown("c"))
        {
            C.SetActive(false);
        }

        if (Input.GetKeyDown("h"))
        {
            H.SetActive(false);
        }

        if (Input.GetKeyDown("o"))
        {
            O.SetActive(false);
        }
    }
}
