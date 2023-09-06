using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LukeSmith
{
    internal class ExceptClass
    {
        public float Divide(float x,  float y)
        {
            if (y == 0) { throw new DivideByZeroException(); }
            else { return x / y; }
        }
        public void CheckAge(int age)
        {
            if (age >= 17) { Console.WriteLine($"You are {age}, you can play mature games"); }
            else { throw new ArgumentException(); }
        }
    }
}
