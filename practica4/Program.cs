using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ejercicio 1
            Console.Write("\n **EJERCICIO 1**");

            List<int> edades = new List<int>();
            string continuar;

            do
            {
                Console.Write("\n Ingresa una edad:");
                int edad = int.Parse(Console.ReadLine());

                if (edad > 0)
                {
                    edades.Add(edad);
                }
                else
                {
                    Console.WriteLine("La edad debe ser positiva. Inténtalo de nuevo.");
                }

                Console.Write("\n¿Deseas ingresar otra edad? (S/N): ");
                continuar = Console.ReadLine().ToUpper();

            } while (continuar == "S");

            if (edades.Count > 0)
            {
                int edadMinima = int.MaxValue;
                int edadMaxima = int.MinValue;

                foreach (int edad in edades)
                {
                    if (edad < edadMinima)
                    {
                        edadMinima = edad;
                    }

                    if (edad > edadMaxima)
                    {
                        edadMaxima = edad;
                    }
                }

                Console.WriteLine($"\nEdad mínima capturada: {edadMinima}");
                Console.WriteLine($"Edad máxima capturada: {edadMaxima}");
            }
            else
            {
                Console.WriteLine("No se capturaron edades.");
            }

            // ejercicio 2
            Console.Write("\n **EJERCICIO 2**");

            Console.Write("\nIngresa el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            int menor = Math.Min(num1, num2);
            int mayor = Math.Max(num1, num2);

            bool hayPrimos = false;

            Console.WriteLine($"\nNúmeros primos entre {menor} y {mayor}:");

            for (int i = menor; i <= mayor; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                    hayPrimos = true;
                }
            }

            if (!hayPrimos)
            {
                Console.WriteLine("No hay números primos en el rango especificado.");
            }

            bool EsPrimo(int numero)
            {
                if (numero <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                        return false;
                }

                return true;
            }

            //ejercicio 3
            Console.Write("\n **EJERCICIO 3**");

            Console.Write("\nIngresa el primer número entero: ");
            int primerNumero = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número entero: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("El primer número debe ser menor que el segundo.");
            }
            else
            {
                int sumaPares = 0;

                for (int i = primerNumero; i <= segundoNumero; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumaPares += i;
                    }
                }

                Console.WriteLine($"\nLa suma de los números pares entre {primerNumero} y {segundoNumero} es: {sumaPares}");
            }


            // ejercicio 4
            Console.Write("\n **EJERCICIO 4**");

            double saldo = 0;
            List<string> bitacora = new List<string>();

            while (true)
            {
                Console.WriteLine("\N|  Cuenta bancaria    |");
                Console.WriteLine("|   Menú de opciones   |");
                Console.WriteLine("|     1) Depósitos     |");
                Console.WriteLine("|     2) Retiros       |");
                Console.WriteLine("|     3) Finalizar     |");
                Console.Write("     Ingresa opción: ");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\n     ** DEPÓSITOS **");
                        Console.Write("Ingresa la cantidad a depositar: ");
                        double deposito = double.Parse(Console.ReadLine());

                        saldo += deposito;
                        bitacora.Add($"Depositó: {deposito}");
                        Console.WriteLine("Depósito realizado exitosamente.");
                        break;

                    case 2:
                        Console.WriteLine("\n     ** RETIROS **");
                        Console.Write("Ingresa la cantidad a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());

                        if (retiro <= saldo)
                        {
                            saldo -= retiro;
                            bitacora.Add($"Retiró: {retiro}");
                            Console.WriteLine("Retiro realizado exitosamente.");
                            Console.WriteLine($"Saldo disponible: {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Fondos insuficientes para realizar el retiro.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n     *** BITÁCORA DE OPERACIONES ***");
                        foreach (string operacion in bitacora)
                        {
                            Console.WriteLine(operacion);
                        }
                        Console.WriteLine($"\nSaldo restante: {saldo}");
                        Console.WriteLine("Finalizando programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }
    }
}

