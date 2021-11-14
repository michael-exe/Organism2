using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D mycollision)
    {
        if (mycollision.collider.tag == "Player")
        {
            Debug.Log("I Have been touched");
            SceneManager.LoadScene("Organism");
        }
    }
}
