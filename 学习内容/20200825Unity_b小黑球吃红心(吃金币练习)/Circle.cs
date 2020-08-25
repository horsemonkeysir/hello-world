using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

    public float moveX;
    public float moveY;
    public float push;

    public AudioSource CoinSound;

    Rigidbody2D rb2D;

    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate() {
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
            CoinSound.Play();
            other.gameObject.SetActive(false);
            
        }
    }
}
