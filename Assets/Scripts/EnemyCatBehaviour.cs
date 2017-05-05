using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCatBehaviour : MonoBehaviour {

    public GameObject cat;
    int timer;

    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        timer++;
        if (timer <= 100)
        {
            cat.GetComponent<BoxCollider>().enabled = false;
            cat.GetComponent<MeshRenderer>().enabled = false;
        }
        if (timer > 200)
        {
            cat.GetComponent<BoxCollider>().enabled = true;
            cat.GetComponent<MeshRenderer>().enabled = true;
        }
        if (timer >= 300)
            timer = 0;
    }
}
