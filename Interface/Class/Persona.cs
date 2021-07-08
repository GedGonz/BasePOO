using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Class
{
    public class Persona
    {
        private readonly ICar car;
        public Persona(ICar car)
        {
            this.car = car;
        }

        public void EnciendoAuto() 
        {
            car.encender();
        }

        public void ApagoAuto()
        {
            car.apagar();
        }

    }
}
