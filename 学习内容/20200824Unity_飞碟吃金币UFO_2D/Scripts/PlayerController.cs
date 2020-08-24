using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    [Header("水平方向")]
    public float moveX;

    [Header("垂直方向")]
    public float moveY;

    [Header("推力")]
    public float push;

    Rigidbody2D rb2D;//钢体,以便可以被施力

    [Header("分数文字UI")]
    public Text countText;//注意,这不是string字串

    [Header("过关文字UI")]
    public Text winText;//注意,这不是string字串

    int score;//分数

    public AudioSource Coin;
    public AudioSource Win;

	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
        //rb2D=取得组件<钢体2D>;

        winText.text = "";//清空过关文字的内容
        setScoreText();//显示 目前分数:0
	}
		
	void FixedUpdate () {
        moveX = Input.GetAxis("Horizontal");
        //水平移动=输入.取得轴向("水平");

        moveY = Input.GetAxis("Vertical");
        //垂直移动=输入.取得轴向("垂直");

        Vector2 movement = new Vector2(moveX, moveY);
        //2维向量  取得方向=新 2维向量(水平移动,垂直移动);

        rb2D.AddForce(push * movement);
        //rb2D.施加力量(推力*移动方向);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(name + "触发了" + other.name);
        Coin.Play();

        if (other.CompareTag("PickUp"))
            //其他.比较标签("PickUp")
        {           
            other.gameObject.SetActive(false);
            //其他.游戏物件.设定活跃状态(否);
            score = score + 1;
            setScoreText();
        }
    }

    void setScoreText()
    {
        countText.text = "目前分数:" + score.ToString();
        //计分数文字UI.文字="目前分数:"+分数.转字串( );

        if (score>=12)
        {
            Win.Play();
            winText.text = "你赢了";
            //过关文字UI.文字="你赢了~!";
        }
    }

}
