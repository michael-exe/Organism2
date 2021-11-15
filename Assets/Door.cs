using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null && collider.tag == "Player")
        {
            SceneManager.LoadScene("Organism");
        }
    }
}
