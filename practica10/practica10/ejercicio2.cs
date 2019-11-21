using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio2
    {
        public void ejer2()
        {
            int op;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("1-)Agregar Paises");
                    Console.WriteLine();
                    Console.WriteLine("2-)Mostrar paises");
                    Console.WriteLine();
                    Console.WriteLine("3-)Salir");
                    Console.WriteLine();
                   op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            StreamWriter Writer = new StreamWriter("paises.txt", true);
                            Console.WriteLine("¿Cuántos países agregará?");
                            int c = Convert.ToInt32(Console.ReadLine());
                            string[] canpaises = new string[c];
                            Console.Clear();
                            for (int i = 0; i < canpaises.Length; i++)
                            {
                                Console.WriteLine("Pais {0}: ", i + 1);
                                canpaises[i] = Console.ReadLine();
                                Writer.WriteLine(canpaises[i]);
                                Console.Clear();
                            }
                            Writer.Close();
                            break;
                        case 2:
                            StreamReader leer = new StreamReader("paises.txt");
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Los países de la lista");
                            Console.WriteLine("=========================");
                            Console.ResetColor();
                            Console.WriteLine(leer.ReadToEnd());
                            leer.Close();
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }

                } while (op != 3);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
