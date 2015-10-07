using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ValuesConventer
    {
        public Kilogramm ConveneterKilo(Weight m)
        {   
            Kilogramm k = new Kilogramm();
            if (m is Gramm)
            {
                k.value = m.value / 1000;
            }
            else if (m is Pound)
            {
                k.value = m.value * 0.41;
            }
            else if (m is Kilogramm)
            {
                k.value = m.value;
            }
            return k;
        }

    }
}
