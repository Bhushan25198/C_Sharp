using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            NamesDisplay("bhushan", "javid");
            NamesDisplay("harshal", "ankit","manish","chetan","01");

            Console.Read();

        }

        private static void NamesDisplay(params string[] parameters)
        {
            Console.WriteLine("Employee Details are as follows......");

            foreach (var item in parameters)
            {
                Console.WriteLine(item);

            }
        }
    }
    
}
