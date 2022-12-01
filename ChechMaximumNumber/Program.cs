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
            //UC1
            Console.WriteLine("Maximum Integer Number is: ");
            int output = UC1MaxInt.MaximumIntegerNumber(65, 21, 15);
            Console.WriteLine(output);

            //UC2
            //Console.WriteLine("Maximum Float Number is:");
            //double doubleoutput = UC2MaxFloat.MaximumFloatNumber(56.3, 87.12, 150.2);
            //Console.WriteLine(doubleoutput);

            //UC3
            //Console.WriteLine("Maximum String value is : ");
            //string strigoutput = UC3MaxString.MaximumStringNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(strigoutput);
            //A - 65, B - 66 C - 67..Z
            //a = 97,b = 98, c = 99..z,
            //'0' - 48, 1 - 49,2 - 50,3 - 51,4 - 52...

            //Refactor 1
            //Console.WriteLine("Maximum Integer Value:" + MaxOf3Values.findmax<int>(3, 4, 2));
            //Console.WriteLine("Maximum Float Value:" + MaxOf3Values.findmax<float>(2.14f, 4.63f, 1.22f));
            //Console.WriteLine("Maximum String Value:" + MaxOf3Values.findmax<string>("aaa", "ccc", "bbb"));

            ////Refactor 2
            //Console.WriteLine("Maximum Integer Is:" + MaxOfValues<int>.findmax(4, 5, 3));
            //Console.WriteLine("Maximum Float Is:" + MaxOfValues<float>.findmax(4.32f, 2.47f, 1.55f));
            //Console.WriteLine("Maximum String Is:" + MaxOfValues<string>.findmax("yyy", "xxx", "zzz"));

            //UC4
            //maximum integer number
            //Console.WriteLine("Maximum Integer Number is: ");
            //int output = UC4.MaximumIntegerNumber(65, 21, 15);
            //Console.WriteLine(output);
            ////Maximum float number
            //Console.WriteLine("Maximum Float Number is:");
            //double doubleoutput = UC4.MaximumFloatNumber(56.3, 87.12, 150.2);
            //Console.WriteLine(doubleoutput);
            ////Maximum String value
            //Console.WriteLine("Maximum String value is : ");
            //string strigoutput = UC4.MaximumStringNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(strigoutput);
            //A - 65, B - 66 C - 67..Z
            //a = 97,b = 98, c = 99..z,
            //'0' - 48, 1 - 49,2 - 50,3 - 51,4 - 52...

            //UC5
            //Console.WriteLine("Find the maximum number: ");
            //int[] arr = { 112, 432, 344, 555, 678 };
            //GenricMaximum<int> generic = new GenricMaximum<int>(arr);
            //generic.PrintMaxValue();
            //double[] doublearr = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            //GenricMaximum<double> genericDouble = new GenricMaximum<double>(doublearr);
            //genericDouble.PrintMaxValue();
            //string[] stringArray = { "111", "222", "333", "55", "999" };
            //GenricMaximum<string> genericString = new GenricMaximum<string>(stringArray);
            //genericString.PrintMaxValue();
        }
    }
}