using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
    

public class ArrayAndList : MonoBehaviour {

    public string[] dateArray;//用Array阵列做个固定张数的约会教战手册
    public List<string> dateList;//用List清单做个活页式的约会教战手册
    public List<contact> phoneBook;//用List清单做个电话本

	void Start () {
        Debug.Log("--------以下是Array阵列--------");
        //为了方便理解，以下是使用张数来比喻而不是页数，因为一张有两页，比较复杂
        dateArray = new string[4];//固定4张纸的笔记本
        dateArray[0] = "0封面Array";//写入第X张纸的资料，从封面开始
        dateArray[1] = "1、别问：你这么漂亮怎么还单身啊？";
        dateArray[2] = "2、别说：我妈说...";
        dateArray[3] = "3、别提：彼此的旧情人";

        Array.Resize(ref dateArray , 5);
        //Array阵列像是粘死的固定张数笔记本，要新增纸张的话必须重新指定大小

        foreach (var page in dateArray)//秀出笔记本内容
        {
            Debug.Log(page);
        }

        //List清单像是活页式的笔记本，系统会自动帮你加纸张
        //Debug.Log("--------以下是List清单--------");
        //dateList.Add("0封面是Array");
        //dateList.Add("1、别问：你这么漂亮怎么还单身啊？");
        //dateList.Add("2、别说：我妈说...");
        //dateList.Add("3、别提：彼此的旧情人");//LIst会自动帮你按顺序排序

        Debug.Log("--------以下是List清单--------");
        dateList.Add("3、别提：彼此的旧情人");
        dateList.Add("1、别问：你这么漂亮怎么还单身啊？");
        dateList.Add("0封面是Array");
        dateList.Add("2、别说：我妈说...");//讲顺序打乱，显示时不管你前面的数字，List仍然帮你按顺序排序，下面有一个矫正排序的方法

        //dateList.RemoveAt(2);

        foreach (var page in dateList)
        {
            Debug.Log(page);
        }

        Debug.Log("--------搜寻含有[说]的资料并显示出来--------");
        foreach (var page in dateList)
        {
            if (page.Contains("说"))
            {
                Debug.Log(page);
            }
        }

        Debug.Log("--------测试List排序--------");
        dateList.Sort();//正向排序
        dateList.Reverse();//反向排序

        foreach (var page in dateList)
        {
            Debug.Log(page);
        }

        Debug.Log("--------阿婆的名册--------");
        phoneBook = new List<contact>();
        phoneBook.Add(new contact("阿花", 79979));
        phoneBook.Add(new contact("阿珠", 76773));
        phoneBook.Add(new contact("阿霞", 56986));

        foreach (var grandma in phoneBook)
        {
            Debug.Log(grandma.name+" "+grandma.phoneNumber);
        }

    }
	
    public struct contact
    {
        public string name;//名字
        public int phoneNumber;//电话

        public contact(string _name,int _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }
    }

	void Update () {
		
	}
}
