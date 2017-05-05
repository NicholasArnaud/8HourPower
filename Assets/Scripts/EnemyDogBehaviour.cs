using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDogBehaviour : MonoBehaviour
{
    int timer;

    void Start()
    {
        timer = 0;
    }


    void Update ()
    {
        timer++;
        if (timer <= 50)
        {
            transform.position += new Vector3(12 * Time.deltaTime, 0.0f, 0.0f);
        }
        if (timer > 50)
        {
            transform.position -= new Vector3(12 * Time.deltaTime, 0.0f, 0.0f);
        }
        if (timer >= 100)
            timer = 0;
    }
}
