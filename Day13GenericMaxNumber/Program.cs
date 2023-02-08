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
            MaxNoAmongThree<int> maxNoAmongThree=new MaxNoAmongThree<int>(12,13,24);
            int output = maxNoAmongThree.MaxMethod();
            Console.WriteLine(output);
            MaxNoAmongThree<float> maxNoAmongThree1=new MaxNoAmongThree<float>(12.3f, 43.3f, 34.5f);
            float output2 = maxNoAmongThree1.MaxMethod();
            Console.WriteLine(output2);
            MaxNoAmongThree<String>maxNoAmong2=new MaxNoAmongThree<String>("varsha", "Suraj", "Vasu");
            String output3 = maxNoAmong2.MaxMethod();
            Console.WriteLine(output3);
            Console.ReadLine();

        }
    }
}
