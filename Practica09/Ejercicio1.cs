using System;
using System.Collections.Generic;
using System.Text;

namespace Practica09
{
    class Ejercicio1
    {
        public static void Mostrar()
        {
            string nombre;
            bool bandera = false;
            int op = 0,Posicion;
            List<string> frutas = new List<string>();
            Console.WriteLine("Frutas");
            do
            {
                Console.WriteLine("Presione <enter> para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("[1] Agregar a lista\n[2] Mostrar lista\n[3] Insertar en la lista\n[4] Eliminar de la lista\n[5] Buscar en la lista\n[6] Vaciar lista\n[7] Salir");
                if (int.TryParse(Console.ReadLine(), out op) && op >= 0 && op<=7)
                {
                    Console.Clear();
                    int i = 1;
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre de una fruta");
                            nombre = Console.ReadLine();
                            frutas.Add(nombre);
                            break;
                        case 2:
                            foreach (string fruta in frutas)
                            {
                                Console.WriteLine("[{0}]:    {1}", i++, fruta);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nombre de una fruta");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la posicion donde desea ingresarlo");
                            if (int.TryParse(Console.ReadLine(), out  i) && i>0)
                            {
                                if(frutas.Count == 0)
                                {   
                                    i = 1;
                                    Console.WriteLine($"No hay elementos en esta lista, el elemento se ingresara en la posicion {i}");
                                    frutas.Insert((i-1), nombre);
                                }
                                else if (frutas.Count <i)
                                {
                                    frutas.Insert(frutas.Count, nombre);
                                }
                                else
                                {  
                                    frutas.Insert((i-1),nombre);
                                }
                            }
                            else
                            {
                                Console.WriteLine("ups... Ingree un numero mayor a cero");
                            }
                            break;
                        case 4:
                            foreach (string fruta in frutas)
                            {
                                Console.WriteLine("[{0}]:    {1}", i++, fruta);
                            }
                            Console.WriteLine("Ingrese el nombre del elemento a eliminar");
                            nombre = Console.ReadLine();
                            if (frutas.Contains(nombre))
                            {
                                frutas.Remove(nombre);
                            }
                            else
                            {
                                Console.WriteLine("Ese valor no esta en la lista");
                            }
                            
                            break;
                        case 5:
                            Console.WriteLine("¿Que elemento desea buscar?");
                            nombre = Console.ReadLine();
                            if (frutas.Contains(nombre))
                            {
                                Posicion = frutas.IndexOf(nombre);
                                Console.WriteLine($"El elemento {frutas[Posicion]} esta en la posicion {Posicion + 1}");
                            }
                            else
                            {
                                Console.WriteLine("Ups ese elemento no exite revisa bien");
                            }
                            break;
                        case 6:
                            frutas.Clear();
                            break;
                        case 7:
                            Console.WriteLine("Gracias por utilizar el programa");
                            bandera = true;
                                break;

                        default:

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar correctamente la cantidad de productos");
                }

            } while (!bandera);
            

        }
    }
}
