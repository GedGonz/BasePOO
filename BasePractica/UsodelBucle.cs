using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public static class UsodelBucle
    {
        public static void Main(string[] args) {

            arreglo();
        }

        public class data 
        {

            public int Id { get; set; }
            public string  name { get; set; }
        }
        public static void arreglo() 
        {
            var array = new string[] { "a", "e", "i", "o", "u" };


            var obj1 = new data() { Id = 1, name = "Helen" };
            var obj2 = new data() { Id = 2, name = "Gerald" };

            var array1 = new data[] { obj1, obj2 };
            var array2 = new data[] { obj1, obj2 };


            //string[] array2 = new string[3];//[0][1][2]

            //for (int i=0; i< array2.Length; i++) 
            //{
            //    array2[i] = i.ToString();
            //    Console.WriteLine("valor: " + array2[i]);
            //}

            //foreach (var elemt in array) 
            //{
            //    Console.WriteLine("valor: " + elemt);
            //}
            var condicion = true;
            var i = 0;
            while (condicion) {

                if ((array.Length - 1) == i)
                {
                    condicion = false;
                }
                else 
                {
                    Console.WriteLine("valor: " + array[i]);
                    i++;
                }

                
            }

        }
        public static void saludoBucle() {

            var lista = new List<string>() {"Hola", "Hola", "Hola", "Hola", "Hola", "Hola", "Hola" };

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine("Hola ", j);
            }

            foreach (var element in lista)
            {
                Console.WriteLine(element);
            }


            var condicion = true;
            var i = 0;
            while (condicion)
            {
                Console.WriteLine("Hola ");
                i++;

                if (i == 10)
                {
                    condicion = false;
                }
            }
            int val = 0;


            while (val != 3)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-OPCION1");
                Console.WriteLine("2-OPCION2");
                Console.WriteLine("3-SALIR");
                val = int.Parse(Console.ReadLine());
            }


            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-OPCION1");
                Console.WriteLine("2-OPCION2");
                Console.WriteLine("3-SALIR");
                val = int.Parse(Console.ReadLine());
            }
            while (val != 3);
        }
    }
}
