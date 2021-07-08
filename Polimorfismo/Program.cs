using Polimorfismo.Area;
using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arma arma = new Revolver();
            //Arma arma2 = new Escopeta();

            //arma.disparar();

            //Forma triangulo = new Triangulo(10,20);
            //triangulo.area();

            //Forma rectangulo = new Rectangulo(10, 20);
            //rectangulo.area();

            //Forma triangulo = new Triangulo(10, 20);
            //triangulo.saludar();


            Forma triangulo = new Triangulo(10, 20);
            var _string=triangulo.ToString();

            Console.WriteLine(triangulo);
        }
    }
}
