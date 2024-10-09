using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    internal class Program
    {
        static void Main()
        {
            // creamos una lista de enteros
            List<int> numeros = new List<int>();
            
            // añadimos valores
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            // mostrara un elemento en la posición 
            Console.WriteLine("Elemento en la posición 3: " + numeros[2]);

            // encontrara numeros mayores a 15
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 15)
                {
                    Console.WriteLine("Número mayor a 15: " + numeros[i]);
                }
            }

            // Convierte la lista a una cadena y mostrarla
            string listaComoTexto = string.Join(", ", numeros);
            Console.WriteLine("Lista como texto: " + listaComoTexto);
            Console.ReadLine();
        }
    }
    
}
