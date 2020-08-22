using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Text : MonoBehaviour {

	//模拟送礼物的过程
	void Start () {
        Person boy = new Person();
        boy.name = "王大明";

        Person girl = new Person();
        girl.name = "阿香";

        Present present=new Present();                 
        present.content = "香水";
        boy.Give(present,girl);
	}
	
    class Person
    {
        public string name;
        public void Give(Present present, Person to)
        {
            Assert.IsNotNull(present.content, "礼物不该是null");//断言 
            Debug.Log(name + "送了" + present.content + "给" + to.name);
        }
    }
    
	class Present
    {
        public string content;//礼物内容
    }
}
