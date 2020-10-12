using System;

namespace Practica09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Write("┌─────────────────────────────────────────┐\n│Ingrese (1) para acceder al menú         │\n└─────────────────────────────────────────┘");
                Console.Write("\n┌─────────────────────────────────────────┐\n│Ingrese (cualquier otra tecla) para salir│\n└─────────────────────────────────────────┘\n");
                if (int.TryParse(Console.ReadLine(), out int n) && n == 1)
                {
                    Console.Clear();
                    Console.WriteLine("                    ┌────┐\n                    │Manú│");
                    Console.Write("┌──────────────────────────────────────────────────┐\n│Ingrese el número del ejercicio que desea ejecutar│\n└──────────────────────────────────────────────────┘\n");
                    Console.WriteLine("│    1) Ejercicio 1(Frutas)                        │ \n│    2) Ejercicio 2(Notas de alumnos)              │ \n│    3) Ejercicio 3(Métodos de pago)               │\n└──────────────────────────────────────────────────┘");
                    bandera = false;
                    if (int.TryParse(Console.ReadLine(), out int op) && op >= 1)
                        switch (op)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                Ejercicio1.Mostrar();
                                Console.WriteLine("Presione enter para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                Ejercicio1.Mostrar();
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Presione enter para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Esta no es una opción válida ");
                                Console.ReadKey();
                                Console.Clear();
                                break;


                        }
                    else
                        Console.WriteLine("Ingrese una opción válida.");

                }
                else
                {
                    bandera = true;
                    Console.WriteLine("Gracias por utilizar el programa bye :) .");
                    Console.WriteLine("Presione <enter> para continuar...");
                    Console.ReadKey();
                }
            } while (!bandera);

        }
    }
}
