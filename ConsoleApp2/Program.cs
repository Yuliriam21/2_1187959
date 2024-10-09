using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primer ejercicio
            float numero1, numero2, suma;

            Console.Write("Ingresa el primer numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());

            suma = numero1 + numero2;

            Console.Write("\nLa suma es: " + suma);


            //segundo ejercicio
            string nombre, profesion, genero;
            int edad;

            Console.Write("\n\nIngresa tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Profesion: ");
            profesion = Console.ReadLine();

            Console.Write("Genero:");
            genero = Console.ReadLine();

            Console.Write("Edad:");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Nombre: " + nombre + " |Profesion: " + profesion + " |Edad: " + edad + " |Genero: " + genero);
            

            //tercer ejercicio
            int horasTrabajadas, salario = 0, horasExtra;

            Console.Write("\n\ningresa las horas trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            if(horasTrabajadas <= 40)
            {
                salario = horasTrabajadas * 50;

            }
            else
            {
                horasExtra = horasTrabajadas - 40;
                salario = (40 * 50) + (horasExtra * 100);
            }
            Console.Write("\nEl salario semanal es: " + salario);
            string genero2 = Console.ReadLine();

            //cuarto ejercicio
            Console.Write("\n\nIntroduce un número de 3 cifras: ");
                int numero3 = int.Parse(Console.ReadLine());

            
            Console.Write("Se rompio 2");
            int numero4 = int.Parse(Console.ReadLine());
            string numeroStr = numero3.ToString();

                char[] numeroArray = numeroStr.ToCharArray();
                Array.Reverse(numeroArray);
                string numeroInvertidoStr = new string(numeroArray);

                int numeroInvertido = Convert.ToInt32(numeroInvertidoStr);

                Console.WriteLine("Número capturado:" +numero3);
                Console.WriteLine("Número invertido:" +numeroInvertido);
                numero4 = int.Parse(Console.ReadLine());
        }
    }

}
