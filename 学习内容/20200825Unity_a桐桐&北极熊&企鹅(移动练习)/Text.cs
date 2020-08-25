using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {

    public float moveX;
    public float moveY;
    public float push;

    Rigidbody2D rb2D;
	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
	}
		
	void Update () {
        moveX = Input.GetAxis("Horizontal");//拼错了,一开始拼成了"Horizantal"
        moveY = Input.GetAxis("Vertical");//又拼错了,拼成了"Certical"
        Vector2 movement = new Vector2(moveX, moveY);
        rb2D.AddForce(push * movement);
	}
}
