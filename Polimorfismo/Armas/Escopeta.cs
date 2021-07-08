using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Escopeta:Arma
    {
        public override void disparar()
        {
            Console.WriteLine("PAM PAM PAM..");
        }
    }
}
