using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            /*
            Circle c1 = new Circle(7.555);
            Circle c2 = new Circle(9.855);
            Circle c3 = new Circle(2.1);
            Console.WriteLine(c1._radius);
            */
            //Circle.pie = 5;
            //Console.WriteLine(Circle.pie);
            //Circle c = new Circle(7.65456);
            Circle.PrintPie();
            
            //c.PrintPie();
            Console.WriteLine();
            MyConsole.WriteLine("Hello");
            Console.WriteLine(MyConsole.creationTime);
            PictureTakenByPhone pic1 = new PictureTakenByPhone();
            PictureTakenByPhone pic2 = new PictureTakenByPhone();

            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                Console.WriteLine(r.Next(1000));
            }
        }
    }
}
