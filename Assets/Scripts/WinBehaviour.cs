using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBehaviour : MonoBehaviour
{
    public Scene scene;
    public GameObject player;
    public Canvas WinCanvas;
    
    void Start ()
    {
        WinCanvas.enabled = false;
    }
	
	private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Winner Found!");
            WinCanvas.enabled = true;
            StartCoroutine(Load(4, "0.main"));
        }
    }

    IEnumerator Load(int Delay, string Load)
    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene(Load);
    }
}
