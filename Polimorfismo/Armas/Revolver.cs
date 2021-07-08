using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Revolver: Arma
    {
        public override void disparar()
        {
            Console.WriteLine("PRA PRA PRA...");
        }
    }
}
