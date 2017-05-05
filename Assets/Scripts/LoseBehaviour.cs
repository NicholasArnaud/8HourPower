using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBehaviour : MonoBehaviour
{
    public GameObject player;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = player.transform.position;
    }

	private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collider activated");
            other.transform.position = initialPosition;
        }
    }
}
