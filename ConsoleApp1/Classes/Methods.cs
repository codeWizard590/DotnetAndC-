using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Methods
    {
        // declaring a anonymous method 
        // in order to declare a anonymous method we need to declare a delegate type
        delegate void PrintDelegate(string s);

        PrintDelegate Print = delegate (string s)
        {
            Console.WriteLine($"string s using delegates : {s}");
        };
        public void delegation(String s)
        {
            Print(s);
        }
    }
}
