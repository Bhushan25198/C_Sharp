using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            // dictionarytask10();
            List<Student> List = new List<Student>();
            for (int i = 0; i < 2; i++)
            {
                Student stu = new Student();

                Console.WriteLine("enter your name");
                stu.FullName = Console.ReadLine();

                Console.WriteLine("enter your phonenum");
                stu.Phonennum = Console.ReadLine();

                Console.WriteLine("enter your course name");
                stu.Coursename = Console.ReadLine();

                Console.WriteLine("enter your id");
                stu.StudentId= Convert.ToInt32 (Console.ReadLine());
                List.Add(stu);

            }
            foreach  (Student item in List)
            {
                Console.WriteLine("student id = " +item.StudentId + "student name = " +item.FullName);

            }
            Console.ReadLine();

        }

        private static void dictionarytask10()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Console.WriteLine("enter your full name");
            string Fullname = Console.ReadLine();
            dic.Add("full_name", Fullname);

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }

            Console.ReadLine();
        }
    }
}
