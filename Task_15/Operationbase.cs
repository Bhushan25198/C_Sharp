using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class OperationBase
    {
        
        public static bool IsPalRecursion(String str, int s, int l)
        {
            if (s == l)

                return true;

            if ((str[s] != str[l]))

                return false;

            if (s < l + 1)

                return IsPalRecursion(str, s + 1, l - 1);
            return true;


        }

    }
}