using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++){
                Console.WriteLine("请把情书传给第"+i+"位同学.");
            }

            int w= 9;
            while (w >= 4)
            {
                Console.WriteLine("班里留有"+w+"位同学在大扫除.");
                w--;
            }

            int d = 6;
            do
            {
                Console.WriteLine("目前到达会议现场的有"+d+"位相关人员.");
                d++;
            }
            while (d <= 16);
        }
    }
}
