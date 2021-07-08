using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class ProgrmacionEstructurada
    {

        public void TiposdeDatos()
        {

            //TIPO DE DATOS
            int a = 1;
            decimal b = 0.1M;
            double x = 0.1;
            long c = 232213213213213;
            string d = "hola";
            bool e = true;  //1 0

            var variable = "";

            dynamic variableDinamic = "hola";


            // ESTRUCTURAS DE DATOS
            string[] array;//[0,1,2,3]
            List<string> lista;
            Dictionary<int, int> diccionario;//1,nombre
            Vector<int> vectores;
            //Tuple<string, string>;
            //Arbol 
            //grafos
            //lista simple 1 2(1)(3) 3(2)(4) 4(3)
            //colas 
            //filas
        }

        //METODOS
        public void saludo1()
        {
            saludo2();

        }
        private void saludo2()
        {

            saludo3();
        }
        protected void saludo3()
        {


        }

        //OPERADORES LOGICO
        //> MAYOR
        //< MENOR
        //== IGUAL 
        //!= DIFERENTE
        //>= MAYOR IGUAL
        //<= MENOR IGUAL
        //&& Y =>AND
        // || O =>OR

        // ESTRUTURA CONDICIONAL 
        public void CONDICIONAL()
        {
            //IF ELSE
            if (true)
            {
                //..
                if (true)
                    Console.WriteLine();


            }
            else if (true)
            {
                //..
            }
            else { }

            //SIWTCH CASE

            switch ("")
            {
                case "a":
                    //...
                    break;
                case "b":
                    //...
                    break;
                case "c":
                    //...
                    break;

                default:
                    //...
                    break;

            }
        }

        // ESTRUTURA DE BUCLE
        public void Bucles()
        {
            for (int i=0; i<10; i++)
            {
            
            }

            foreach (var element in new List<string>()) 
            {
            
            }

            var operacion = 0;

            while (operacion==0) {
                //...
                operacion = 1;
            }

            do {
            
            
            
            } while(true);

        }



    }
}
