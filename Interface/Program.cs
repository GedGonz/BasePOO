using Interface.Class;
using Interface.Interface;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICar car = new Toyota();

            //var helen = new Persona(car);

            //helen.EnciendoAuto();

            //helen.ApagoAuto();

            ICar car = new Wolzwagen();

            var helen = new Persona(car);

            helen.EnciendoAuto();

            helen.ApagoAuto();
        }
    }
}
