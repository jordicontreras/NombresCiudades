using System;

namespace NombreCiudades
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //********* FASE 1 *********
            //Declaramos 6 variables vacías
            var var1 = "";
            var var2 = "";
            var var3 = "";
            var var4 = "";
            var var5 = "";
            var var6 = "";


            Console.WriteLine("********* FASE 1 *********");

            //Pedimos al usuario que nos introduzca las ciudades y las guardamos en sus respectivas variables
            Console.WriteLine("Introduce el nombre de una ciudad");
            var1 = Console.ReadLine();

            Console.WriteLine("Introduce el nombre de una ciudad");
            var2 = Console.ReadLine();

            Console.WriteLine("Introduce el nombre de una ciudad");
            var3 = Console.ReadLine();

            Console.WriteLine("Introduce el nombre de una ciudad");
            var4 = Console.ReadLine();

            Console.WriteLine("Introduce el nombre de una ciudad");
            var5 = Console.ReadLine();

            Console.WriteLine("Introduce el nombre de una ciudad");
            var6 = Console.ReadLine();

            //Imprimimos los nombres de las ciudades introducidas
            Console.WriteLine("");
            Console.WriteLine("Nombres ciudades en variables");
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);


            //********* FASE 2 *********
            Console.WriteLine("");
            Console.WriteLine("********* FASE 2 *********");

            //Creamos array con las ciudades introducidas
            string[] arrayCiudades = new string[] { var1, var2, var3, var4, var5, var6 };
            
            //Ordenamos el array por orden alfabético
            Array.Sort(arrayCiudades);

            //Llamamos a la función que imprime al array de ciudades(le pasamos el array ordenado)
            Console.WriteLine("Mostramos array ciudades por orden alfabético");
            ImprimeCiudades(arrayCiudades);


            //********* FASE 3 *********
            Console.WriteLine("");
            Console.WriteLine("********* FASE 3 *********");

            //Llamamos a la función de ciudades modificadas
            CiudadesModificadas(arrayCiudades);


            //********* FASE 4 *********
            Console.WriteLine("");
            Console.WriteLine("********* FASE 4 *********");

            //Llamamos a la función de ciudades modificadas
            ArraysCiudadesChar(arrayCiudades);

        }



        //Funcion que imprime el array de ciudades
        static void ImprimeCiudades(Array arrayCiudades)
        {
            foreach (string ciudad in arrayCiudades)
            {
                Console.WriteLine(ciudad);
            }
        }


        //Función que guarda en un nuevo array las ciudades cambiando su letra "a" por un "4"
        static void CiudadesModificadas(Array arrayCiudades)
        {
            //Creamos el array de ciudades modificadas
            string[] arrayCiudadesModificadas = new string[6];

            //Recorremos el arrayCiudades para cambiar la letra "a" por un "4" y guardar esos valores en arrayCiudadesModificadas
            int i = 0;
            foreach (string ciudad in arrayCiudades)
            {
                arrayCiudadesModificadas[i] = ciudad.Replace('a', '4');
                i++;
            }

            //Ordenamos el array por orden alfabético
            Array.Sort(arrayCiudadesModificadas);

            //Mostramos por consola el nuevo array modificado arrayCiudadesModificadas
            Console.WriteLine("Mostramos el array de ciudades modificadas");
            foreach (string ciudad in arrayCiudadesModificadas)
            {
                Console.WriteLine(ciudad); 
            }     
        }


        //Funcion que crea un array de array con los char de los nombres de las ciudades
        static void ArraysCiudadesChar(Array arrayCiudades)
        {
            char[][] nuevoArray = new char[arrayCiudades.Length][];
            int i = 0;

            foreach(string ciudad in arrayCiudades)
            {
                nuevoArray[i] = ciudad.ToCharArray();
                i++;
            }


            Console.WriteLine("Mostramos las ciudades al revés");

            //Imprimimos los valores del array al revés
            for (int v = 0; v < nuevoArray.Length; v++)
            {
                for(int z = nuevoArray[v].Length-1; z>=0 ; z--)
                {
                    Console.Write(nuevoArray[v][z]);
                }
                Console.WriteLine("");
            }

        }


    }
}
