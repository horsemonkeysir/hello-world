03.角色移动
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMove= Input.GetAxis("Horizontal");
        if (horizontalMove !=0)
        {
            rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
        }
    }
}

