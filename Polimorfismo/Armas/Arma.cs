using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Arma
    {
        public virtual void disparar() 
        {
            Console.WriteLine("PUM PUM PUM..");
        }
    }
}
