using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hola Mundo");
            Console.ReadLine();
            Console.WriteLine("Adios Mundo");
            Console.ReadLine(); este es un comentario de bloque*/

            //Declarar variables

            /*int numEntero = 3;
            float numDecimal = 1.56F;
            string cadCaracter = "Mi nombre es Mundo";
            char caracter = 'a';
            bool booleano = true;

            Console.WriteLine("El numero decimal es " + numDecimal + " La cadena de caracter es " + cadCaracter + " El caracter " + caracter + " y este es un booleano " + booleano);
            Console.ReadLine();

            //Ingresar datos y modificar una variable
            Console.WriteLine("Inserta un nuevo numero para la variable");
            numEntero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nuevo valor es de " + numEntero);
            Console.ReadLine();

            //Declaracion de variable string o cadena de texto

            string nombreCompleto = "Jose de Jesus";
            Console.WriteLine("Mi nombre es: " + nombreCompleto);
            Console.ReadLine();

            string texto1;
            texto1 = "Hola";

            string texto2;
            Console.WriteLine("Ingresa tu nombre: ");
            texto2 = Console.ReadLine();
            Console.WriteLine(texto1 + " " + texto2 + " Bienvenido");
            Console.ReadLine(); */

            /*int num1, num2;

            Console.WriteLine("Ingresa 2 numeros enteros");
            Console.WriteLine("Ingresa el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la suma de sus numeros es: " + (num1 + num2));
            Console.ReadLine();  */

            bool esMasculino;
            
            int op;


            Console.WriteLine("¿Cual es tu género?");
            Console.WriteLine("1.-Selección 1 - Femenino");
            Console.WriteLine("2.-Selección 2 - Masculino");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1) {
                esMasculino = false;
                Console.WriteLine(esMasculino);
                Console.ReadLine();
            }
            else if (op == 2){
                esMasculino = true;
                Console.WriteLine(esMasculino);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
                Console.ReadLine();
            }







        }
        
    }
    
}
