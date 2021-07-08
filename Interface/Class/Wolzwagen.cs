using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Class
{
    public class Wolzwagen : ICar
    {
        public void andar()
        {
            Console.WriteLine("El Wolzwagen se mueve!");
        }

        public void apagar()
        {
            Console.WriteLine("El Wolzwagen se Apago!");
        }

        public void cambio(int n)
        {
            Console.WriteLine($"Se aplico el cambio: {n} al Wolzwagen");
        }

        public void encender()
        {
            Console.WriteLine("El Wolzwagen se Encendio!");
        }

        public void frenar()
        {
            Console.WriteLine("El Wolzwagen freno!");
        }
    }
}
