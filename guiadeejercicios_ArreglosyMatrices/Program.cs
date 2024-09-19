using System;

namespace Ejercicio2
{
    public class Programa
    {
        static void Main(string[] agrs)
        {
            //asignar asientos en cada vuelo del único avión de la aerolínea
            //capacidad del avión (10 asientos)
            Console.WriteLine("Sistema de Reservaciones de Aerolínea Jaguar");
            Console.WriteLine("Sistema Automatizado de Reservaciones");
            Console.WriteLine();

            //inicializar los asientos con sus valores específicos
            int[] asientos_smoking = { 1, 2, 3, 4, 5 }; //sección de fumar
            int[] asientos_nonsmoking = { 6, 7, 8, 9, 10 }; //sección de no fumar
            int asientos_smoking_available = asientos_smoking.Length;//contador de asientos disponibles
            int asientos_nonsmoking_available = asientos_nonsmoking.Length;// ''

            //llevar el control de los asientos asignados
            int index_smoking = 0;
            int index_nonsmoking = 0;

            while (asientos_smoking_available > 0 || asientos_nonsmoking_available > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, teclee 1 para sección de fumar");
                Console.WriteLine("Por favor, teclee 2 para sección de no fumar");
                Console.Write("Opción: ");
                int opcion_usuario;

                //validamos que el usuario introduce 1 y 2
                while(!int.TryParse(Console.ReadLine(), out opcion_usuario) || (opcion_usuario !=1 && opcion_usuario != 2))
                {
                    Console.WriteLine("Entrada invalida. Por favor teclee 1 para fumar o 2 para no fumar. ");
                }


                //usamos un switch para tomar la opción del usuario
                switch (opcion_usuario)
                {
                    case 1: //sección de fumar
                        {
                            if (asientos_smoking_available > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Asiento asignado: {asientos_smoking[index_smoking]}");
                                Console.WriteLine("Sección: Fumar");
                                index_smoking++;
                                asientos_smoking_available--; //decrementa asientos disponibles
                            }
                            else
                            {
                                Console.WriteLine("La sección de fumar está llena");
                                Console.Write("Le parece aceptable ser colocado en la sección de no fumar? (si/no): ");
                                string respuesta = Console.ReadLine();
                                if (respuesta.ToLower() == "si")
                                {
                                    if (asientos_nonsmoking_available > 0)
                                    {
                                        Console.WriteLine($"Asiento asignado: {asientos_nonsmoking[index_nonsmoking]}");
                                        Console.WriteLine("Sección: No Fumar");
                                        index_nonsmoking++;
                                        asientos_nonsmoking_available--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lo sentimos, el vuelo está lleno");

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El próximo vuelo sale en 3 horas");
                                    
                                }
                            }
                            break;
                        }

                    case 2: //sección de no fumar
                        {
                            if (asientos_nonsmoking_available > 0)
                            {
                                Console.WriteLine($"Asiento asignado: {asientos_nonsmoking[index_nonsmoking]}");
                                Console.WriteLine("Sección: No Fumar");
                                index_nonsmoking++;//avanza al sig asiento
                                asientos_nonsmoking_available--; //decrementa asientos disponibles
                            }
                            else
                            {
                                Console.WriteLine("La sección de no fumar está llena");
                                Console.Write("Le parece aceptable ser colocado en la sección de fumar? (si/no): ");
                                string respuesta = Console.ReadLine();
                                if (respuesta.ToLower() == "si")
                                {
                                    if (asientos_smoking_available > 0)
                                    {
                                        Console.WriteLine($"Asiento asignado: {asientos_smoking[index_smoking]}");
                                        Console.WriteLine("Sección: Fumar");
                                        index_smoking++;
                                        asientos_smoking_available--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lo sentimos, el vuelo está lleno");
                             
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El próximo vuelo sale en 3 horas");
                             
                                }
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Opción inválida.");
                            break;
                        }

                }

                //comprobar si ya no quedan asientos en las amabas secciones
                if (asientos_smoking_available == 0 && asientos_nonsmoking_available == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Todos los asientos estan ocupados. El proximo vuelo sale en 3 horas.");
                    Console.WriteLine("----- El avion va a despegar. -------");
                    break;
                }

            }



        }
    }
}