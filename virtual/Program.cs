using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleAllEqual allEqual = new TriangleAllEqual(7);
            int hekef = allEqual.CalcHekef();
            Console.WriteLine(hekef);
            Console.WriteLine(allEqual.CalcHekef());
            Person p1 = new Person("Danny", 18);
            var p2 = new Person("Danny", 18, "Tel aviv");

            //Console.WriteLine(x.GetType());

            Type t = ("anc").GetType();
            object s1 = Activator.CreateInstance(t);

            
            //string s2 = (string)Activator.CreateInstance();
        }
    }
}
