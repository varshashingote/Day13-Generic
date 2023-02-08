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
            MaxNoAmongThree maxNoAmongThree=new MaxNoAmongThree();
            int output= MaxNoAmongThree.MaxIntegerNumberCheck(10, 20, 30);
            float output2 = MaxNoAmongThree.MaxFloatNumberCheck(12.3f, 32.3f, 44.3f);
            String output3 = MaxNoAmongThree.MaxSringNumberCheck("Varsha", "Suraj", "vasu");
            Console.WriteLine(output);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.ReadLine();

        }
    }
}
