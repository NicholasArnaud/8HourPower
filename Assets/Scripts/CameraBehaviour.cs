using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Camera Cam;
    private Vector3 offset;
	// Use this for initialization
	void Start ()
    {
        offset = Cam.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Cam.transform.position = transform.position + offset;
	}
}
