using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour {

    public float moveX;

    public float moveY;

    public float push;

    Rigidbody2D rb2D;

	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        moveX = Input.GetAxis("Horizontal");

        moveY = Input.GetAxis("Vertical");//Vertical当时拼错了

        Vector2 movement = new Vector2(moveX, moveY);

        rb2D.AddForce(push * movement);//这一句没记住,AddForce后面用了"=",而且后面的括号前想着还有别的
	}
}
