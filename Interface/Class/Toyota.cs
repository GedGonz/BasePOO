using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Class
{
    public class Toyota : ICar
    {
        public void apagar()
        {
            Console.WriteLine("El auto se Apago!");
        }

        public void andar()
        {
            Console.WriteLine("El auto se mueve!");
        }

        public void cambio(int n)
        {
            Console.WriteLine($"Se aplico el cambio: {n}");
        }

        public void encender()
        {
            Console.WriteLine("El auto encendio");
        }

        public void frenar()
        {
            Console.WriteLine("El auto freno");
        }
    }
}
