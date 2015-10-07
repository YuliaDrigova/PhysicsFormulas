using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Force
    {
        public double value;

        public Force(double value)
        {
            this.value = value;
        }

        public static Force operator +(Force f1, Force f2)
        {
            return new Force(f1.value + f2.value);
        }

        public static Force operator -(Force f1, Force f2)
        {
            return new Force(f1.value - f2.value);
        }

        public static double operator /(Force f1, Force f2)
        {
            double value = f1.value / f2.value;
            return value;
        }

        public static Weight operator /(Force f, Acceleration a)
        {
            return new Weight(f.value / a.value);                       
        }

        public static Acceleration operator /(Force f, Weight w)
        {
            ValuesConventer conv = new ValuesConventer();
            return new Acceleration(f.value / conv.ConveneterKilo(w).value);
        }
    }
}
