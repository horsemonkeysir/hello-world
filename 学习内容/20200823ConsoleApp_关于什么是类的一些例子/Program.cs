using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu = new Student() { ID = 1, Name = "Timothy" };
            //Student后面的小括号没东西叫"默认构造器",大括号叫"初始化器"
            //Console.WriteLine(stu.ID);
            //Console.WriteLine(stu.Name);
            //stu.Report();
            //当后面给出一个Student实例的时候,这里的小括号如果再空着就会报错,因为他不能用默认值了
            //Student stu = new Student(1, "Timothy");  //实例构造器         
            //stu.Report();
            //创建实例也不一定非得用new操作符
            //Type t = typeof(Student);
            //object o = Activator.CreateInstance(t,1,"Timothy");
            //Student stu = o as Student;
            //Console.WriteLine(stu.Name);//反射
            Student s1 = new Student(1, "Timothy");
            Student s2 = new Student(2, "Jacky");
            Console.WriteLine(Student.Amount);
        }
    }

    class Student
    {
        public static int Amount { get; set; }
        static Student()//静态构造器,只能用来构造静态成员,不能构造实例成员
        {
            Amount = 100;
        }
        public Student(int id,string name)//实例构造器
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }

        ~Student()//吸购器,也叫吸购函数
        {
            Amount--;
        }
       
        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I`m #{ID} student, my name is {Name}.");
        }     
    }
}
