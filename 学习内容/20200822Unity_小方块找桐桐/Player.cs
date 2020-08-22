using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D playerRigidbody2D;

    [Header("目前的水平速度")]
    public float speedX;

    [Header("目前的水平方向")]
    public float horizontalDirection;//数值会在-1~1之间(负数代表方向向左,正数是向右)

    const string HORIZONTAL = "Horizontal";//为了降低出错的概率,把复杂的字串变为常数是种不错的方法

    [Header("水平推力")]
    [Range(0, 150)]
    public float xForce;

    //目前的垂直速度
    float speedY;

    [Header("最大水平速度")]
    public float maxSpeedX;
    public void Controlspeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX,speedY);
    }

    [Header("垂直向上推力")]
    public float yForce;
    public bool JumpKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }

    void TryJump()
    {
        if (IsGround&&JumpKey)
        {
            playerRigidbody2D.AddForce(Vector2.up*yForce);
        }
    }

    [Header("感应地板的距离")]
    [Range(0,0.5f)]
    public float distance;

    [Header("侦测地板的射线起点")]
    public Transform groundCheck;

    [Header("地面图层")]
    public LayerMask groundLayer;

    public bool grounded;
    //在玩家的底部射一条很短的射线,如果射线有打到地板图层的话,代表正在踩着地板
    bool IsGround
    {
        get
        {
            Vector2 start = groundCheck.position;
            Vector2 end = new Vector2(start.x, start.y - distance);
            Debug.DrawLine(start, end, Color.blue);
            grounded = Physics2D.Linecast(start, end, groundLayer);
            return grounded;

        }
    }

    void Start () {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
	}
	
    /// <summary>水平移动</summary>
    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);//这里如果没设常数,则要输入"Horizontal",假如没注意打错了,程序即会出错
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
    }

	// Update is called once per frame
	void Update () {
        MovementX();
        Controlspeed();
        TryJump();
        //speedX = playerRigidbody2D.velocity.x;
    }
}
