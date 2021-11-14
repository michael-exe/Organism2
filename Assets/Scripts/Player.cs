using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    Vector2 movement;

    public float throwSpeed;        
    public List<GameObject> objectGrabed;

    void Update()
    {
        //INPUT
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(objectGrabed.Count >= 1 && Input.GetKeyDown(KeyCode.X)) {
            
            var obj = objectGrabed[objectGrabed.Count -1];
            obj.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            obj.GetComponent<Rigidbody2D>().AddForce(obj.transform.parent.up*throwSpeed);
            obj.transform.SetParent(null);
            Destroy(obj,3f);
            objectGrabed.RemoveAt(objectGrabed.Count-1);
        }
    }

    private void FixedUpdate()
    {
        //MOVEMENT
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Door")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    //https://youtu.be/whzomFgjT50 Movement
    //https://youtu.be/gAB64vfbrhI Collision

}
