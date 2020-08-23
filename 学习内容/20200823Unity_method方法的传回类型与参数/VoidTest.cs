using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidTest : MonoBehaviour {

    string playerName = "小明";
    int playerAppetite = 1000;//食量(公克)

	void EattingTime()
    {
        Debug.Log("吃饭时间到了");//第一种,没有回传类型,括号里也没参数,所以能应用的空间有限,但不容易出错
    }

    void TimeToEat(string meal)
    {
        Debug.Log("吃" + meal + "的时间到了");//第二种,应用弹性比较大,但运用出错的概率也大
    }

    string steak = "牛排";
    int steakQuantity = 800;

    /// <summary>
    /// 吃东西
    /// </summary>
    /// <param name="meal">餐点</param>
    /// <param name="quantity">餐点分量</param>
    string TimeToEat(string meal,int quantity)
    {
        string eat="吃" + meal + "的时间到了,"+playerName;
        if (quantity>playerAppetite)
        {
            return eat  + "吃不下" + meal;
        }
        else
        {
            return eat  + "吃了" + meal;
        }
    }


    void Start () {
        //TimeToEat("早餐");
        //TimeToEat("午餐");
        //TimeToEat("晚餐");

        TimeToEat(steak);
        if (steakQuantity > playerAppetite)
        {
            Debug.Log(playerName + "吃不下" + steak);
        }
        else
        {
            Debug.Log(playerName + "吃了" + steak);
        }

        Debug.Log(TimeToEat("牛排套餐", 1200));
        Debug.Log(TimeToEat("布丁", 200));
    }
	
    //总结,void比较封闭,没有参数没有回传,但不容易出错,而string,带参数带回传,应用空间就大了很多,调好之后效率也会更高,但出错的概率相对大
    
	
}
