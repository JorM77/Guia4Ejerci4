using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4Ejerci4
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c = new Coche(1, "BMW", "1", 500, 10000, false);
            Moto m = new Moto(2, "Toyota", "2", 100, 5000, true);
            Bus a = new Bus(3, "MARCOPOLO", "3", 200, 8000, false);

            Console.WriteLine("Precio coche: " + c.precio);
            Console.WriteLine("Precio moto: " + m.precio);
            Console.WriteLine("Precio Bus: " + a.precio);

            Console.WriteLine(c.ToString());
            Console.WriteLine(m.ToString());
            Console.WriteLine(a.ToString());


            Console.ReadLine();

        }
    }
}
