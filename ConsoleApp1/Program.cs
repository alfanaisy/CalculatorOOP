using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(1, 2);
            Console.WriteLine(a1.Process());
            a1.Display();
            Pengurangan b1 = new Pengurangan(5, 1);
            Console.WriteLine(b1.Process());
            b1.Display();
            Perkalian c1 = new Perkalian(3, 4);
            Console.WriteLine(c1.Process()); 
            c1.Display();
            Pembagian d1 = new Pembagian(6, 6);
            Console.WriteLine(d1.Process()); 
            d1.Display();

            Console.Read();

        }
        class Pertambahan: DemoAbstract
        {
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Process()
            {
                return A + B;
            }
        }

        class Pengurangan : DemoAbstract
        {
            public Pengurangan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Process()
            {
                return A - B;
            }
        }

        class Perkalian : DemoAbstract
        {
            public Perkalian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Process()
            {
                return A * B;
            }
        }

        class Pembagian : DemoAbstract
        {
            public Pembagian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Process()
            {
                return A / B;
            }
        }
    }
}

