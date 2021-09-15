//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System;
namespace Task_12
{
    class sample
    {
        public static void IFutureMethod()
        {
            Console.WriteLine("IFutureMethod method");
        }
        public void ZensarMethod(string v)
        {
            first();
            Console.WriteLine("ZensarMethod method");
        }

        public void first()
        {

        }

        public void ZensarMethod(int i)
        {
            Console.WriteLine(i);
            ZensarMethod();
        }

        private void ZensarMethod()
        {
            throw new NotImplementedException();
        }
    }
    class program
    {
        public static void Main_15()
        {
            sample obj = new sample();
            obj.first();
            obj.ZensarMethod("Akkki");
            Console.Read();
        }
    }
}


