using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class CircleTest : MonoBehaviour
{
    //public float moveX;
    //public float moveY;
    //public float push;
    public float speed;

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        //moveX = Input.GetAxis("Horizontal");
        //moveY = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2(moveX, moveY);
        //rb2D.AddForce(push * movement);
        movement();
    }

    void movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        if (horizontalMove != 0 || verticalMove !=0)
        {
            rb2D.velocity = new Vector2(horizontalMove * speed, verticalMove*speed);            
        }
        
    }
}
