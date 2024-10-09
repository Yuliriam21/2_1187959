using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            int promedio = 5;
            int suma = 0;
            int calificacion;

            for (int i = 0; i < promedio; i++)
            {
                Console.Write("Ingresa la Calificacion: ");
                calificacion = int.Parse(Console.ReadLine());
                suma = suma + calificacion;
            }

            int califinal = suma / promedio;
            Console.Write("\nEl promedio es: " + califinal);

            if(califinal >= 60)
            {
                Console.WriteLine("\nEl alumno a aprobado *w*.");
            }
            else
            {
                Console.WriteLine("El alumno no aprobo. :--C");
            }


            //Ejercicio 2

            string genero;
            int edad;

            Console.Write("\n\nIngresa tu edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu Sexo: ");
            genero = Console.ReadLine();

            if(edad >= 18)
            {
                Console.WriteLine("\nEres mayor de edad, tu Sexo es " + genero);
            }
            else
            {
                Console.WriteLine("\nEres menor de edad, tu Sexo es ");
            }

            //Ejercicio 3

            int numero;


            Console.Write("\n\nIntroduce un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nEs un número par.");
            }
            else
            {
                Console.WriteLine("\nEs un número impar.");
            }

            //Ejercicio 4

            int num = 3;
            int numero1, numero2, numero3;

        
                Console.Write("\n\nIngresa numero 1: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa numero 2: ");
                numero2 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa numero 3: ");
                numero3 = int.Parse(Console.ReadLine());

                int mayor = Math.Max(numero1, Math.Max(numero2, numero3));
                int menor = Math.Min(numero1, Math.Min(numero2, numero3));

                Console.WriteLine("\nEl numero mayor es: " + mayor);
                Console.WriteLine("\nEl numero menor es: " + menor);

                

            //Ejercicio 5

            Console.Write("\n\nIngrese un numero: ");
            double numeroE  = Convert.ToDouble(Console.ReadLine());

            double valorAbsoluto = Math.Abs(numeroE);
            double potencia = Math.Pow(numeroE, 2);
            double raizCuadrada = Math.Sqrt(numeroE);
            double seno = Math.Sin(numeroE);
            double coseno = Math.Cos(numeroE);
            double redondeo = Math.Round(numeroE);
            double truncado = Math.Truncate(numeroE);

            Console.WriteLine("Valor absoluto: " + valorAbsoluto);
            Console.WriteLine("Potencia (elevado al cuadrado): " + potencia);
            Console.WriteLine("Raíz cuadrada: " + raizCuadrada);
            Console.WriteLine("Seno: " + seno);
            Console.WriteLine("Coseno: " + coseno);
            Console.WriteLine("Redondeo: " + redondeo);
            Console.WriteLine("Truncado: " + truncado);
            Console.ReadLine();

        }
    }
}
