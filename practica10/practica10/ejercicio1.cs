using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio1
    {
       public void ejer1()
        {

            if (!File.Exists(@"c:\datos"))
            {
                Directory.CreateDirectory(@"c:\datos");
            }

            string pais;
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1-)Agregar país");
                Console.WriteLine("2-)Mostrar paises");
                Console.WriteLine("3-)Buscar país");
                Console.WriteLine("4-)Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        try
                        {
                            Console.Clear();
                            StreamWriter arpaises = new StreamWriter(@"c:\datos\paises.txt", true);
                            Console.WriteLine("Ingrese el país");
                            Console.WriteLine();
                            pais = Console.ReadLine();
                            arpaises.WriteLine(pais);
                            arpaises.Close();
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Error al guardar archivo");
                        }


                        break;
                    case 2:
                        Console.Clear();
                        StreamReader paises = new StreamReader(@"c:\datos\paises.txt");
                        string linea;
                        
                            linea = paises.ReadToEnd();
                            Console.WriteLine(linea);
                        paises.Close();
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Busqueda de paises");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese nombre del pais a buscar");
                        Console.Write("País: ");
                        string buscarpais;
                        buscarpais = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Resultados de busqueda ");
                        Console.WriteLine();
                        Console.WriteLine();
                        StreamReader buspais = new StreamReader(@"C:\datos\paises.txt");

                        string busqueda;
                        do
                        {
                            busqueda = buspais.ReadLine();
                            if (busqueda != null)

                            {

                                if (busqueda == buscarpais)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(buscarpais);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.WriteLine(busqueda);
                                }
                            }
                        } while (busqueda != null);
                        buspais.Close();
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        break;

                }
            } while (op != 4);
        }
    }
}
