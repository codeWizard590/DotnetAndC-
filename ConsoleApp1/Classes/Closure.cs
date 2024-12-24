using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Closure
    {
        public int number = 0;
        public Func<int> func()
        {
            return () =>
            {
                number++;
                return number;
            };
        }
    }
}
