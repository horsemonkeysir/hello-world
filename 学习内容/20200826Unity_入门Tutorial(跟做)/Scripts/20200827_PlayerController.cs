using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public float speed;
    public float jumpForce;
    public LayerMask ground;
    public Collider2D coll;
    public int Cherry;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // 不是每个电脑的配置都能达到默认帧数,所以加个Fixed来固定帧数
    void Update()
    {
        Movement();
        SwitchAnim();
    }

    void Movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");//直接赋值就好,不需要再另起一行
        float faceDirection = Input.GetAxisRaw("Horizontal");
        //和GetAxis不同的是,加个Raw就只定义-1,0,1三个数,而不是-1到1的所有

        //角色移动
        if (horizontalMove != 0)
        {
            rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
            anim.SetFloat("running", Mathf.Abs(faceDirection));
        }

        if (faceDirection != 0)
        {
            transform.localScale = new Vector3(faceDirection, 1, 1);
        }

        //角色跳跃
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetBool("jumping", true);
        }
    }

    void SwitchAnim()
    {
        anim.SetBool("idle", false);

        if (anim.GetBool("jumping"))
        {
            if (rb.velocity.y < 0)
            {
                anim.SetBool("jumping", false);
                anim.SetBool("falling", true);
            }
        }
        else if (coll.IsTouchingLayers(ground))
        {
            anim.SetBool("falling", false);
            anim.SetBool("idle", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Collection")
        {
            Destroy(collision.gameObject);
            Cherry += 1;
        }
    }
}
