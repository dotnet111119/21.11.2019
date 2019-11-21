using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    public class Triangle
    {
        public int _a;
        public int _b;
        public int _c;

        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public virtual int CalcHekef()
        {
            return _a + _b + _c;
        }

        public override string ToString()
        {
            return $"Triangle a:{_a} b:{_b} c:{_c}";
        }
    }
}
