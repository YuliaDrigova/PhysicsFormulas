using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Acceleration
    {
        public double value;

        public Acceleration(double value)
        {
            this.value = value;
        }

        public static Acceleration operator +(Acceleration a1, Acceleration a2)
        {
            return new Acceleration(a1.value + a2.value);
        }

        public static Acceleration operator -(Acceleration a1, Acceleration a2)
        {
            return new Acceleration(a1.value - a2.value);
        }

        public static double operator /(Acceleration a1, Acceleration a2)
        {
            double value = a1.value/a2.value;
            return value;
        }

        public static Acceleration operator *(Acceleration a1, Acceleration a2)
        {
            throw new Exception("Impossible operation!");
        }
    }
}
