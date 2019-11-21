using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111_
{
    public static class MyConsole
    {
        /*
        public void foo()
        {

        }
        */
        public const int neverChange = 12;
        public static DateTime creationTime;

        static MyConsole()
        {
            creationTime = DateTime.Now;
        }


        public static void WriteLine(string str)
        {
            Console.WriteLine($"**** {str} *****");
        }
    }

}
