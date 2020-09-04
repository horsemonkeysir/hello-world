using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaTest : MonoBehaviour
{
    public float moveX;
    public float moveY;
    //public float push;
    public float speed;

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX=Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2(moveX, moveY);
        //rb2D.AddForce(push * movement);
        if (moveX !=0 || moveY!=0)
        {
            rb2D.velocity = new Vector2(moveX * speed, moveY * speed);
        }
    }
}
