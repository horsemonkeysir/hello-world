using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property_Script : MonoBehaviour {
    //第一个例子
    //限制别人存取你的重要资料,版手机的时候不会给身份证正本,只会给影本

    string _id = "身份证正本";
    public string ID
    {
        get { return _id + "的影本"; }

    }

    //第二个例子
    int _hp = 100;
    public int HP
    {
        get { return _hp; }
        set
        {
            _hp = value;
            if (_hp < 0)
            {
                _hp = 0;
            }
        
        }
    }

	void Start () {
        Debug.Log("例子1\n通讯行员工拿到了" + ID);

        Debug.Log("例子2\n目前生命值" + HP);
        HP -= 109;
        Debug.Log("例子2\n目前生命值" + HP);
	}
	
	
}
