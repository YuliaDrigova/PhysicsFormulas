using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Weight
    {
        public double value;

        public Weight()
        { }

        public Weight(double mass)
        {
            this.value = mass;
        }
        
        public static ValuesConventer conv = new ValuesConventer();
       
        public static Weight operator +(Weight m1, Weight m2)
        {
            return new Weight(conv.ConveneterKilo(m1).value + conv.ConveneterKilo(m2).value);
        }

        public static Weight operator -(Weight m1, Weight m2)
        {
            return new Weight(conv.ConveneterKilo(m1).value - conv.ConveneterKilo(m2).value);
        }

        public static double operator /(Weight m1, Weight m2)
        {
            double value = m1.value / m2.value;
            return value;
        }

        public static Weight operator *(Weight m1, Weight m2)
        {
            throw new Exception("Impossible operation!");
        }
    }
}
