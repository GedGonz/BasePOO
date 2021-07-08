using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Area
{
    public class Rectangulo : Forma
    {
        private int Base { get; set; }
        private int Altura { get; set; }
        public Rectangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override int area()
        {
            return (Base * Altura);
        }

        public override void saludar()
        {
            Console.WriteLine("HOLA SOY RECTANGULO!");
        }
    }
}
