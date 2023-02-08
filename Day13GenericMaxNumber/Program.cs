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
            int[] array ={1,9,3,5 };
            MaximumNumber<int> generic = new MaximumNumber<int>(array);
            Console.WriteLine(generic.MaxValue());
            //generic.PrintMaxValue();

            Console.ReadLine();

        }
    }
}
