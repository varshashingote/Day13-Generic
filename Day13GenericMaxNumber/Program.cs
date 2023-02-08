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
            int output= MaxNoAmongThree.MaxIntegerNumberCheck(10, 80, 30);
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
