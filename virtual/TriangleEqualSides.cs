using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    public class TriangleEqualSides : Triangle
    {
        public TriangleEqualSides(int a, int c) : base(a, a, c)
        {
        }

        public override int CalcHekef()
        {
            return _a * 2 + _c;
        }
    }
}
