using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main()
        {
            //primer ejercicio

            int edad;

            Console.Write("Ingresa tu edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18) {
                Console.WriteLine("*Eres mayor de edad*");
                Console.WriteLine();
            }
            else {
                Console.WriteLine("*Eres menor de edad*");
                Console.WriteLine();
            } 

            //segundo ejercicio

            int year;
            bool bisiesto = false;

            Console.Write("Ingresa un año:");
            year = int.Parse(Console.ReadLine());

            bisiesto = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
            Console.WriteLine(bisiesto ? "*Es año bisiesto*" : "*No es año bisiesto*");
            Console.WriteLine();

            //tercer ejercicio
            int opc = 0;
            string entrada;

            do
            {
                Console.WriteLine("\n1) Rectangulo");
                Console.WriteLine("2) Circulo");
                Console.WriteLine("3) Triangulo");
                Console.WriteLine("Salir");
                Console.Write("Ingresa la opcion:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        int b, resultado, altura;

                        Console.Write("\nIngresa la base del rectangulo:");
                        b = int.Parse(Console.ReadLine());

                        Console.Write("Ingresa la altura del triangulo:");
                        altura = int.Parse(Console.ReadLine());

                        resultado = b * altura;

                        Console.Write("\n\nLa area del triangulo es:" + resultado);

                        break;

                    case 2:
                        double radio, area, pi = 3.141592;
                        Console.Write("\nIngresa el radio del circulo");
                        radio = int.Parse(Console.ReadLine());
                        area = pi * radio * radio;
                        Console.Write("\n\nEl area del circulo es:" + area);

                        break;

                    case 3:
                        double bace, h, x;
                        Console.Write("\nIngresa la altura del triangulo:");
                        h = double.Parse(Console.ReadLine());
                        Console.Write("\nIngresa la base del triangulo:");
                        bace = double.Parse(Console.ReadLine());
                        x = bace * h / 2;
                        Console.WriteLine("\n\nEl area del triangulo es: " + x);

                        break;

                    case 4:
                        Console.Write("saliendo del programa..");
                        break;
                    default:
                        Console.Write("Opcion Invalida.");
                        break;

                } 
                

            } while (opc != 0);
            Console.WriteLine("");
        }
    }
}
