using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Weight m = new Gramm();
            m.value = 500;
            Force f = new Force(10);
            Acceleration a = f/m;
            Console.WriteLine(a.value);
            Console.ReadKey();
        }
    }
}
