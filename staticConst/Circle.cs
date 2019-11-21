using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111_
{
    public class Circle
    {
        public double _radius;
        public int hi = 12;
        public const double pie = 3.14;
        public static readonly double calculatedPie;
        public static int counterOfCircles = 0;
        //public const DateTime creationTime = DateTime.Now; // will not work!
        public static readonly int x;
        static Circle()
        {
            calculatedPie = CalculatePie();
            Console.WriteLine("Going static");
            //Math.PI;
        }

        static readonly Random r = new Random();

        private static double CalculatePie()
        {
            throw new NotImplementedException();
        }

        public Circle(double radius)
        {
            //x = 15;
            //x = 17;
            //x = 19;
            _radius = radius;
            counterOfCircles++;

            
            _radius = r.Next(400);
        }

        public override string ToString()
        {
            return $"Circle {_radius}";
        }
        public static void PrintPie()
        {
            Console.WriteLine(Circle.pie);
        }

        public void PrintRadius()
        {
            Console.WriteLine(this._radius);
        }
    }
}
