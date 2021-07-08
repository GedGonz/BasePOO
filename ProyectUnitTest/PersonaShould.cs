using Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProyectUnitTest
{
    public class PersonaShould
    {
        [Fact]
        public void Create_Person_Validate()
        {
            var helen = new Persona();
            helen.Nombre = "Helen";
            helen.Apellido = "Morales";
            helen.Saludar();
        }
    }
}
