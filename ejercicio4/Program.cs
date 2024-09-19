using System;

namespace Ejercicio4
{
    class Programa
    {
        const int tamanoArreglo = 10; //num de empleados a ingresar

        static void Main()
        {
            //arreglo para almacenar los contadores de cada rango de salario
            int[] contadores = new int[9]; //9 rangos de salario definidos
            float ventas;

            Console.WriteLine("==============================================");
            Console.WriteLine("   Cálculo de Rangos de Salarios de Empleados");
            Console.WriteLine("==============================================");

            //iterar sobre cada empleado para ingresar sus ventas y calcular su salario
            for (int i = 0; i < tamanoArreglo; i++)
            {
                Console.WriteLine($"\nIntroduzca las ventas del empleado número {i + 1}:");
                ventas = float.Parse(Console.ReadLine());

                //calcular el salario total del empleado basado en ventas
                float salario = (0.09f * ventas) + 200.00f;

                //truncar el salario a una cantidad entera para la clasificación en rangos
                int salarioTruncado = (int)salario;

                //determinar el rango del salario basado en el salario truncado
                int rango;

                if (salarioTruncado >= 200 && salarioTruncado <= 299)
                {
                    rango = 0; //rango para salarios entre $200 y $299
                }
                else if (salarioTruncado >= 300 && salarioTruncado <= 399)
                {
                    rango = 1; //rango para salarios entre $300 y $399
                }
                else if (salarioTruncado >= 400 && salarioTruncado <= 499)
                {
                    rango = 2; //rango para salarios entre $400 y $499
                }
                else if (salarioTruncado >= 500 && salarioTruncado <= 599)
                {
                    rango = 3; //rango para salarios entre $500 y $599
                }
                else if (salarioTruncado >= 600 && salarioTruncado <= 699)
                {
                    rango = 4; //rango para salarios entre $600 y $699
                }
                else if (salarioTruncado >= 700 && salarioTruncado <= 799)
                {
                    rango = 5; //rango para salarios entre $700 y $799
                }
                else if (salarioTruncado >= 800 && salarioTruncado <= 899)
                {
                    rango = 6; //rango para salarios entre $800 y $899
                }
                else if (salarioTruncado >= 900 && salarioTruncado <= 999)
                {
                    rango = 7; //rango para salarios entre $900 y $999
                }
                else
                {
                    rango = 8; //rango para salarios de $1000 o más
                }

                //incrementar el contador del rango correspondiente
                contadores[rango]++;
            }

            //mostrar el número de empleados en cada rango de salario
            Console.WriteLine("\n==============================================");
            Console.WriteLine("   Resultados de los Rangos de Salarios");
            Console.WriteLine("==============================================");

            Console.WriteLine($"Entre $200 y $299: {contadores[0]} empleados");
            Console.WriteLine($"Entre $300 y $399: {contadores[1]} empleados");
            Console.WriteLine($"Entre $400 y $499: {contadores[2]} empleados");
            Console.WriteLine($"Entre $500 y $599: {contadores[3]} empleados");
            Console.WriteLine($"Entre $600 y $699: {contadores[4]} empleados");
            Console.WriteLine($"Entre $700 y $799: {contadores[5]} empleados");
            Console.WriteLine($"Entre $800 y $899: {contadores[6]} empleados");
            Console.WriteLine($"Entre $900 y $999: {contadores[7]} empleados");
            Console.WriteLine($"$1000 o más: {contadores[8]} empleados");

            Console.WriteLine("==============================================");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}