using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightMarketLife : MonoBehaviour {

	//什么是人类？
    class 人类
    {
        public string 称号;//属性（特征）
        public int 胃容量 = 100;//属性（特征）

        public void 报上大名()//方法（行为）
        {
            Debug.Log(称号 + "的大名你没有听过吗？哇哈哈！");
        }

        public void 吃东西(店家 某个店家)
        {
            int 剩余胃容量 = 胃容量 - 20;
            某个店家.产品数量 -= 1;
            Debug.Log(称号 + "吃了一份" + 某个店家.产品名);
            Debug.Log(称号 + "的胃容量剩下" + 剩余胃容量 + "%");
            Debug.Log(某个店家.产品名 + "的数量为" + 某个店家.产品数量);
        }


    }
    class 店家
    {
        public string 店家名;
        public string 产品名;
        public int 产品数量;

        public void 吆喝()
        {
            Debug.Log(店家名 + "的老板吆喝着：来喔各位！好吃的" + 产品名 + "里面坐喔！");
        }
    }


	void Start () {
        人类 王大明 = new 人类();//在这个类别规范下，相当于"new"生出了"王大明"
        王大明.称号 = "三重王识贤";
        王大明.报上大名();//调用方法（行为）

        店家 臭豆腐店 = new 店家();
        臭豆腐店.店家名 = "阿香臭豆腐";
        臭豆腐店.产品名 = "臭豆腐";
        臭豆腐店.产品数量 = 30;
        臭豆腐店.吆喝();

        王大明.吃东西(臭豆腐店);
            

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
