using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo u = new UserInfo("admin", "admin", "admin@gmail.com");
            
            int i = 0;

            do
            {
                Console.WriteLine("Enter Username:");
                u.UserName = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                u.Password = Console.ReadLine();

                Console.WriteLine("Enter EmailID:");
                u.EmailID = Console.ReadLine();

                if (u.UserName != "admin" || u.Password != "admin")
                    i++;
                else
                    i = 1;
            } while (u.UserName != "admin" || u.Password != "admin" && i != 3);
            if (i == 3)
            {
                Console.WriteLine("You have three time attemted login. Please try again later....!!!!!!");
            }
            else
            {
                Console.WriteLine("You have logged in successfully.....Welcome to the portal!!!!!!!!");
            }
            Console.ReadLine();
        }
    }
}
