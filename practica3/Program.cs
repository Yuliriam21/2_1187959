using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                
                Console.WriteLine("1.numcuadrado");
                Console.WriteLine("2.calcu");
                Console.WriteLine("3.mayora50");
                Console.WriteLine("ecoje [ ] \b\b");
                int menu =int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ecoje del 1 a l 8");
                        int num1 = int.Parse(Console.ReadLine());

                        int total = 0;
                        switch (num1)
                        {
                            case 1:
                                total = num1 * num1;
                                break;
                            case 2:
                                total = num1 * num1;
                                break;
                            case 3:
                                total = num1 * num1;
                                break;
                            case 4:
                                total = num1 * num1;
                                break;
                            case 5:
                                total = num1 * num1;
                                break;
                            case 6:
                                total = num1 * num1;
                                break;
                            case 7:
                                total = num1 * num1;
                                break;
                            case 8:
                                total = num1 * num1;
                                break;
                            default: Console.WriteLine("error");
                                break;
                                
                        }
                        Console.WriteLine("r = " + total);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("num1");
                        Console.WriteLine("num2");
                        int nume1=int.Parse(Console.ReadLine());
                        int num2=int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
            } while (true);
        }
    }
}
