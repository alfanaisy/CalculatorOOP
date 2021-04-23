using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class DemoAbstract
    {
        public abstract int Process();

        public void Display()
        {
            Console.WriteLine("Perhitungan Selesai");
        }
    }
}
