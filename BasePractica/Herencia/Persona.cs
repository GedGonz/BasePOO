using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }


        public void Saludar() 
        {
            Console.WriteLine($"Hola mi nombre es: {Nombre} {Apellido}");
        }

    }


}
