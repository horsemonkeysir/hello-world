using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
//public class 旋转器:MonoBehaviour

	void Update ()//void更新() 每秒执行越60次
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
        //变形.旋转(新 3维向量(0,0,45)*时间.时间变化)
        //总之可以理解为每秒以Z轴为中心转45度

        //面对一个人的时候:
        //对方点头 就是头部沿着X轴在旋转
        //对方摇头 就是头部沿着Y轴在旋转
        //对方摆头顶着肩膀 就是头部沿着Z轴在旋转
	}
}
