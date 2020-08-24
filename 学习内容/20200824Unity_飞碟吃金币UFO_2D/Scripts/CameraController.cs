using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [Header("玩家物件")]
    public GameObject player;

    [Header("相对位移")]
    public Vector3 offset;//宣告成public可以即使修改数值



	void Start () {
        offset = transform.position - player.transform.position;
        //相对位移=摄影机的坐标-玩家的坐标
	}
	
	
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        //摄影机的坐标=玩家的坐标+相对位移
	}
}
