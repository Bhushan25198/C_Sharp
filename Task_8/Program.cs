using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {

            var tuples = Tuple.Create(true, "bhushan", "ravindra", 2501, 2.5);
            Console.WriteLine(tuples.Item1);
            Console.WriteLine(tuples.Item2);
            Console.WriteLine(tuples.Item3);
            Console.WriteLine(tuples.Item4);
            Console.WriteLine(tuples.Item5);

            Console.ReadLine();
        }
    }
}
