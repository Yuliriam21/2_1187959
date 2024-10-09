using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la calificacion del 1 al 10:");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 10:
                    Console.Write("Exelente");
                    break;
                case 9:
                    Console.Write("Muy bien");
                    break;
                case 8:
                    Console.Write("Bien");
                    break;
                case 7:
                    Console.Write("Regular");
                    break;
                case 6:
                    Console.Write("suficiente");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.Write("Insuficiente");
                    break;
                default:
                    Console.Write("Se ingresó un valor fuera de rango");

                    break;

            }
            Console.ReadKey();

        }
    }
}
