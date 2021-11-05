using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    Vector2 movement;

    public float throwSpeed;        
    public GameObject _lastObjectGrabed;

    void Update()
    {
        //INPUT
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(_lastObjectGrabed && Input.GetKeyDown(KeyCode.X)) {
            
            _lastObjectGrabed.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            _lastObjectGrabed.GetComponent<Rigidbody2D>().AddForce(_lastObjectGrabed.transform.parent.up*throwSpeed);
            _lastObjectGrabed.transform.SetParent(null);
            Destroy(_lastObjectGrabed,3f);
            _lastObjectGrabed= null;
        }
    }

    private void FixedUpdate()
    {
        //MOVEMENT
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }  
    //https://youtu.be/whzomFgjT50 Movement


}
