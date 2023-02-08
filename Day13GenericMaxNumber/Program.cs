using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13GenericMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNoAmongThree<int> maxNoAmongThree=new MaxNoAmongThree<int>();
            int output= MaxNoAmongThree<int>.MaxIntegerNumberCheck(12,34,13);
            Console.WriteLine(output);
            MaxNoAmongThree<float> maxNoAmongThree1=new MaxNoAmongThree<float>();
            float output2 = MaxNoAmongThree<float>.MaxIntegerNumberCheck(12.3f, 43.3f, 34.5f);
            Console.WriteLine(output2);
            MaxNoAmongThree<String>maxNoAmong2=new MaxNoAmongThree<String>();
            String output3 = MaxNoAmongThree<String>.MaxIntegerNumberCheck("varsha", "Suraj", "Vasu");
            Console.WriteLine(output3);
            Console.ReadLine();

        }
    }
}
