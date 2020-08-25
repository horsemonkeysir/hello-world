using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCoin : MonoBehaviour {

    public float moveX;
    public float moveY;
    public float push;
    Rigidbody2D rb2D;

    public AudioSource Coin;

	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate () {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        rb2D.AddForce(push * movement);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(name + "触发了" + other.name);

        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Coin.Play();
        }
    }


}
