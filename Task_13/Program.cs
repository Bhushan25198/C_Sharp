using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            FiveEmpDetail();

            ITEmployee t = new ITEmployee();


        }

        private static void FiveEmpDetail()
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { id = 101, name = "bhushan", age = 21, salary = 5000 });
            emp.Add(new Employee { id = 101, name = "harshal", age = 22, salary = 6000 });
            emp.Add(new Employee { id = 101, name = "ankit", age = 23, salary = 7000 });
            emp.Add(new Employee { id = 101, name = "manish", age = 24, salary = 8000 });
            emp.Add(new Employee { id = 101, name = "sagar", age = 24, salary = 8000 });

            foreach (var Employee in emp)


            {
                Console.WriteLine("id: {0},name:{1},age:{2},salary:{3}", Employee.id, Employee.name, Employee.age, Employee.salary);

            }
                  Console.ReadLine();

          
  
  
        }
    }
}   