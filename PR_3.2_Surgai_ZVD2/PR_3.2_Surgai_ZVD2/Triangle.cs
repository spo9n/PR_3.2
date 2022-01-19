using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._2_Surgai_ZVD2
{
    class Triangle : IEquilateralTriangle, IIsoscelesTriangle, IVersatileTriangle, 
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double _a, double _b, double _c)
        {
            this.a = _a;
            this.b = _b;
            this.c = _c;
        }
    }
}
