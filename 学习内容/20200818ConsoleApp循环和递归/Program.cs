using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.PrintXTo1(10);
            
        }
    }

    class Calculator
    {
        //public void PrintXTo1(int x)
        //{
        //    for (int i = x; i > 0; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //循环

        public void PrintXTo1(int x)
        {
            if(x==1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo1(x - 1);
            }
        }
        //递归

        //下面用以上两种方法计算1到100的和

        //public int SumFrom1ToX(int x)
        //{
        //    int result = 0;
        //    for (int i = 1; i < x+1; i++)
        //    {
        //        result = result + i;
        //    }

        //    return result;
        //}
        //循环

        //public int SumFrom1ToX(int x)
        //{
        //    if(x==1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        int result = x + SumFrom1ToX(x - 1);
        //        return result;
        //    }
        //}
        //递归

        //public int SumFrom1ToX(int x)
        //{
        //    return (1 + x) * x / 2;
        //}
        //数学公式

    }
}
