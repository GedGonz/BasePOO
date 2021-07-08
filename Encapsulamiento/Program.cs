using System;

namespace Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            var persona = new persona();
            var persona2 = new persona("Andrea","Morales","San sebastian");
            persona2.Saludar();

            persona.setNombre("Helen");
            persona.setApellido("Morales");
            //......
            persona.setNombre("Andrea");


            var direccion = persona.Direcion;
            persona.getNombre();
            persona.save();
        }
    }
}
