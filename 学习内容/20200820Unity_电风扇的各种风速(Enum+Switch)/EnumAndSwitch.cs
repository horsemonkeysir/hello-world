using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumAndSwitch : MonoBehaviour {

    enum Fanstate  //宣告一个列举Enum，基本用法类似不能转风向的电风扇，同一时间只会有一种状态
    { off,low,medium,high}//关闭，低风速，中风速，高风速

    enum GameState//游戏状态
    { StartMenu,Playing,Pauce,GameOver}//标题画面，游戏中，暂停，游戏结束

	void Start () {
        //使用列举Enum,同时按下开关按钮，注意字母大小写有别
        Fanstate fanstate = Fanstate.medium;

        switch (fanstate) //输入switch后连按两下Tab，然后括号内输入fanstate后连按两下Enter，下面会自己出来四种状态
        {
            case Fanstate.off:
                Debug.Log("电风扇关闭");
                break;

            case Fanstate.low:
                Debug.Log("电风扇切换成低风速");
                break;

            case Fanstate.medium:
                Debug.Log("电风扇切换成中风速");
                break;

            case Fanstate.high:
                Debug.Log("电风扇切换成高风速");
                break;

            default:
                Debug.Log("未知的电风扇状态");
                break;
        }

        GameState gameState = GameState.Playing;

        switch (gameState)
        {
            case GameState.StartMenu:
                Debug.Log("切换到标题画面");
                break;

            case GameState.Playing:
                Debug.Log("正在玩游戏");
                Debug.Log("其他case的执行码不会执行");
                break;

            case GameState.Pauce:
                Debug.Log("游戏暂停");
                break;

            case GameState.GameOver:
                Debug.Log("游戏结束");
                break;

            default:
                Debug.Log("未知的游戏状态");
                break;
        }
    }
}
