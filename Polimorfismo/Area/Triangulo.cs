using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Area
{
    public class Triangulo : Forma
    {
        private int Base { get; set; }
        private int Altura { get; set; }

        public Triangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        
        public override int area()
        {
            return (Base * Altura) / 2;
        }

        public override void saludar()
        {
            Console.WriteLine("HOLA SOY UN TRIANGULO!");
        }

        public override decimal volumen()
        {
            return 5.2m;
        }

        public override void save()
        {
            Console.WriteLine("Guardando desde mysql");
        }


    }
}
