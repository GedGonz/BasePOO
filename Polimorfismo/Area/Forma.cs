using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Area
{
    public abstract class Forma
    {
        abstract public int area();
        public virtual void saludar() 
        {
            Console.WriteLine("HOLA SOY FORMA!");
        }

        public virtual void Despida() {
            Console.WriteLine("ADIOS!!");
        }

        public virtual decimal volumen()
        {
            return 8.5M;
        }

        public virtual void save()
        {
            Console.WriteLine("guardo los dato SQL!!");
        }
    }
}
