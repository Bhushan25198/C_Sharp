using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1400, "Python");
            dic.Add(456, "Java");
            dic.Add(1900, "Javascript");
            dic.Add(1500, "sql");
            dic.Add(1200, "Csharp");


            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine("Rank: {0} - {1}", i+1, dic.Values(i));

            }
            Console.Read();

        }
    }
}
