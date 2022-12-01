using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChechMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //Refactor 1
            Console.WriteLine("Maximum Integer Value:" + MaxOf3Values.findmax<int>(3, 4, 2));
            Console.WriteLine("Maximum Float Value:" + MaxOf3Values.findmax<float>(2.14f, 4.63f, 1.22f));
            Console.WriteLine("Maximum String Value:" + MaxOf3Values.findmax<string>("aaa", "ccc", "bbb"));

            ////Refactor 2
            //Console.WriteLine("Maximum Integer Is:" + MaxOfValues<int>.findmax(4, 5, 3));
            //Console.WriteLine("Maximum Float Is:" + MaxOfValues<float>.findmax(4.32f, 2.47f, 1.55f));
            //Console.WriteLine("Maximum String Is:" + MaxOfValues<string>.findmax("yyy", "xxx", "zzz"));

        }
    }
}