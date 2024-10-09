using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero del 1 al 8");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.WriteLine("El cuadrado de 1 es: " + (1 * 1));
                    break;

                case 2:
                    Console.WriteLine("El cuadrado de 2 es: " + (2 * 2));
                    break;

                case 3:
                    Console.WriteLine("El cuadrado de 3 es: " + (3 * 3));
                    break;

                case 4:
                    Console.WriteLine("El cuadrado de 4 es: " + (4 * 4));
                    break;

                case 5:
                    Console.WriteLine("El cuadrado de 5 es: " + (5 * 5));
                    break;

                case 6:
                    Console.WriteLine("El cuadrado de 6 es: " + (6 * 6));
                    break;

                case 7:
                    Console.WriteLine("El cuadrado de 7 es: " + (7 * 7));
                    break;

                case 8:
                    Console.WriteLine("El cuadrado de 8 es: " + (8 * 8));
                    break;
                default:
                    Console.Write("Se ingresó un valor fuera de rango");
                    break;
            }
           

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número (1 para suma, 2 para resta, 3 para multiplicación, 4 para división): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            
            switch (opcion)
            {
                case 1:
                    
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;

                case 2:
                    
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;

                case 3:
                    
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;

                case 4:
                  
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la división es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }
                    break;

                default:
                    
                    Console.WriteLine("Opción no válida. Por favor ingrese un número entre 1 y 4.");
                    break;
            }

            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            switch (numero)
            {
                case int n when (n < 50):
                    Console.WriteLine("El número es menor a 50.");
                    break;

                case int n when (n > 50):
                    Console.WriteLine("El número es mayor a 50.");
                    break;

                case int n when (n == 50):
                    Console.WriteLine("El número es igual a 50.");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
