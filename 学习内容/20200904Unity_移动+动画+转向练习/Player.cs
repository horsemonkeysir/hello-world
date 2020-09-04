using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveX;
    public float moveY;
    public float speed;
    public float faceDirection;

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

        void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        faceDirection = Input.GetAxisRaw("Horizontal");
        if (moveX!=0||moveY!=0)
        {
            rb2D.velocity = new Vector2(moveX * speed, moveY * speed);
        }
        if (faceDirection!=0)
        {
            transform.localScale = new Vector3(faceDirection, 1, 1);
        }
    }
}
