using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girlfriend : MonoBehaviour {
    public class 人类
    {
        const string 永远的女神 = "波多野结衣";
        public void 说出我的女神()
        {
            Debug.Log(名字 + "表示：我的女神只有一个！");
            Debug.Log("那就是" + 永远的女神 + "啊啊啊啊啊！");
        }


        public string 名字;
        //public bool 吃辣;
        public static bool 吃辣;//试试static的效果

        public void 回答吃不吃辣()
        {
            if (吃辣 == true)
            {
                Debug.Log(名字 + "表示：我吃辣");
            }
            else
            {
                Debug.Log(名字 + "表示：我不吃辣");
            }
        }

        public 人类(string 父母取的名字)
        {
            名字 = 父母取的名字;//添加名字的另一种方案
        }

        public void 在一起(人类 对象)
        {
            Debug.Log("就在这个时候" + 名字 + "跟" + 对象.名字 + "天雷勾动地火，怦怦碰碰动动，他们在一起了！");
            王大明的女朋友.自己 = 对象;
            Debug.Log(名字 + "现在跟" + 王大明的女朋友.自己.名字 + "稳定交往中");
        }
    }
    static class 王大明的女朋友 {
        public static 人类 自己;
        public static string 男朋友 = "大明";
    }


	// Use this for initialization
	void Start () {
        //人类 王大明 = new 人类();//出生
        //人类 陈阿香 = new 人类();//出生

        //王大明.名字 = "大明";
        //陈阿香.名字 = "阿香";

        //王大明.吃辣 = true;
        //陈阿香.吃辣 = false;

        //王大明.回答吃不吃辣();
        //陈阿香.回答吃不吃辣();

        //===或者在上面就添加名字代码===

        人类 王大明 = new 人类("大明");//出生
        人类 陈阿香 = new 人类("阿香");//出生  
        人类 张阿珠 = new 人类("阿珠");//出生

        //王大明.吃辣 = true;
        //陈阿香.吃辣 = false;
        //===试试static的效果===
        人类.吃辣 = true;

        王大明.回答吃不吃辣();
        陈阿香.回答吃不吃辣();

        //王大明的女朋友 女朋友1 = new 王大明的女朋友();
        //王大明的女朋友 女朋友2 = new 王大明的女朋友();
        //女朋友1.名字 = "真真";
        //女朋友2.名字 = "妮妮";

        //Debug.Log("王大明有两个女友，叫做" + 女朋友1.名字 + "跟" + 女朋友2.名字);
        //Debug.Log("王大明迷失在他的美梦里，永远醒不来了...");

        王大明.在一起(陈阿香);
        Debug.Log("相爱容易相处难，他们两个分手了...");
        王大明.在一起(张阿珠);

        王大明.说出我的女神();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
