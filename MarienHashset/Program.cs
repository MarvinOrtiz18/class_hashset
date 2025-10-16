//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="UNAN Managua CUR-Carazo">
//     Author: MAOG18
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace MarienHashset
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Titulo de la consola
            Console.Title = "CRUD HASHSET";
            // Declaración de variables
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            // Opción salir del menú
            bool salir = false;

            // Ciclo Do-While
            do
            {
                // Variable para iterar en las opciones del menú
                // Obtiene su valor de la función Menu, la cual retorna un entero
                int opcion = Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1:/// Opción Insertar Datos CREATE
                           /// Pasamos como parametros A y B
                        InsertarDatos(A, B);
                        break;
                    case 2:/// Opción Mostrar Datos READ
                           /// Pasamos como parametros A y B
                        MostrarDatos(A, B);
                        break;
                    case 3:/// Opción Actualizar Datos UPDATE
                           /// Pasamos como parametros A y B
                        ActualizarDato(A, B);
                        break;
                    case 4:/// Opción Eliminar Datos DELETE
                           /// Pasamos como parametros A y B
                        EliminarDato(A, B);
                        break;
                    case 5:/// Opción Buscar Datos SEARCH
                           /// Pasamos como parametros A y B
                        BuscarDato(A, B);
                        break;
                    case 6:/// Opción Salir del Programa
                        salir = true;
                        break;
                    default:
                        /// Mensaje al registrar una opción no válida
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
                if (!salir)
                {
                    Console.WriteLine("Presione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            } while (!salir);
            Console.WriteLine("Saliendo del programa...");
        }

        /// Funcion MENU
        public static int Menu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("MENU CRUD HASHSET");
            Console.WriteLine();
            Console.WriteLine("1-> Insertar datos en el conjunto");
            Console.WriteLine("2-> Mostrar datos en el conjunto");
            Console.WriteLine("3-> Actualizar un dato en el conjunto");
            Console.WriteLine("4-> Eliminar un dato en el conjunto");
            Console.WriteLine("5-> Buscar un dato en el conjunto");
            Console.WriteLine("6-> Salir...");
            Console.WriteLine();
            Console.Write("Opción : ");
            int.TryParse(Console.ReadLine(), out opcion);

            return opcion;
        }

        /// Funcion Insertar Datos
        public static void InsertarDatos(HashSet<int> A, HashSet<int> B)
        {
            try
            {
                Console.Write("Ingrese los valores para el conjunto A (separados por coma): ");
                string inputA = Console.ReadLine();
                foreach (var item in inputA.Split(','))
                {
                    if (int.TryParse(item.Trim(), out int value))
                        A.Add(value);
                    else
                        throw new FormatException($"Valor no valido en el conjunto A: '{item.Trim()}'");
                }
                Console.WriteLine("Los valores actuales de A son: " + string.Join(", ", A));
                Console.WriteLine();

                Console.Write("Ingrese los valores para el conjunto B (separados por coma): ");
                string inputB = Console.ReadLine();
                foreach (var item in inputB.Split(','))
                {
                    if (int.TryParse(item.Trim(), out int value))
                        B.Add(value);
                    else
                        throw new FormatException($"Valor no valido en el conjunto B: '{item.Trim()}'");
                }
                Console.WriteLine("Los valores actuales de B son: " + string.Join(", ", B));
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
        }

        /// Funcion Mostrar Datos
        public static void MostrarDatos(HashSet<int> A, HashSet<int> B)
        {
            Console.WriteLine("Valores de A: " + string.Join(", ", A));
            Console.WriteLine();
            Console.WriteLine("Valores de B: " + string.Join(", ", B));
            Console.WriteLine();
            // Operaciones de conjuntos
            HashSet<int> union = new HashSet<int>(A);
            union.UnionWith(B);
            Console.WriteLine("Unión A y B: " + string.Join(", ", union));
            Console.WriteLine();
            HashSet<int> interseccion = new HashSet<int>(A);
            interseccion.IntersectWith(B);
            Console.WriteLine("Intersección A y B: " + string.Join(", ", interseccion));
            Console.WriteLine();
            HashSet<int> diferencia = new HashSet<int>(A);
            diferencia.ExceptWith(B);
            Console.WriteLine("Diferencia de A y B: " + string.Join(", ", diferencia));
        }

        /// Funcion Actualizar Datos
        public static void ActualizarDato(HashSet<int> A, HashSet<int> B)
        {
            return;
        }

        /// Funcion Eliminar Datos
        public static void EliminarDato(HashSet<int> A, HashSet<int> B)
        {
            return;
        }

        /// Funcion Buscar Datos
        public static void BuscarDato(HashSet<int> A, HashSet<int> B)
        {
            return;
        }
    }
}
