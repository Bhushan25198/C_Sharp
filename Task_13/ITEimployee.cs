using System;

namespace Task_13
{
    internal class ITEimployee
    {
        public static implicit operator ITEimployee(ITEmployee v)
        {
            throw new NotImplementedException();
        }
    }
}