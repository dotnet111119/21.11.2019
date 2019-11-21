using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    public class TriangleAllEqual : Triangle
    {
        public TriangleAllEqual(int a) : base(a, a, a)
        {
        }

        public sealed override int CalcHekef()
        {
            return _a * 3;
        }
    }
}
