using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class persona
    {
        private string nombre;
        private string apellido;

        public string Direcion { get; }

        public persona()
        {

        }
        public persona(string nombre1)
        {
            nombre = nombre1;
        }
        public persona(string nombre1,string apellido1, string direccion1)
        {
            nombre = nombre1;
            apellido = apellido1;
            Direcion = direccion1;
        }

        public void setNombre(string nombre) 
        {
            if (!string.IsNullOrEmpty(this.nombre))
            {
                Console.WriteLine($"No se puede asignar otro nombre");
            }
            else {

                this.nombre = nombre;
            }
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }


        public string getNombre() 
        {
            return nombre;
        }

        public void Saludar() 
        {
            Console.WriteLine($"Hola mi nombre es: {nombre} {apellido}");
        }

        public void save() 
        {
            Console.WriteLine($"Se guardo la persona: {nombre} {apellido}");
        }
    }
}
