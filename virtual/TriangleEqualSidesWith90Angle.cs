using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    public class TriangleEqualSidesWith90Angle : TriangleEqualSides
    {
        public TriangleEqualSidesWith90Angle(int a, int c) : base(a, c)
        {
        }

        // overloading not working with return value
        //public void foo()
        //{
        //}
        //public string foo()
        //{
            //return "hello";
        //}

        public override int CalcHekef()
        {
            //base.CalcHekef(); // calls parent
            return _a * _c;
        }
    }
}
