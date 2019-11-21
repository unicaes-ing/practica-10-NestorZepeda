using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*****************");
                    Console.WriteLine("   Practica 10");
                    Console.WriteLine("*****************");
                    Console.WriteLine();
                    Console.WriteLine("Ejercicio 1");
                    Console.WriteLine("Ejercicio 2");
                    Console.WriteLine("Ejercicio 3");
                    Console.WriteLine();
                    Console.Write("Opción: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            ejercicio1 ejer1 = new ejercicio1();
                            ejer1.ejer1();
                            break;
                        case 2:
                            ejercicio2 ejer2 = new ejercicio2();
                            ejer2.ejer2();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;


                    }
                } while (op != 3);
            }
            catch (Exception)
            {

            }
        }
    }
}
