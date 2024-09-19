using System;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            //el programa tira 36,000 veces los dos dados
            /*Existen 6 formas de llegar a un 7, por lo que
            una sexta parte de todas las tiradas deberán ser 7*/
            Console.WriteLine("Simulacion de Tirar Dos Dados");
            Console.WriteLine();

            //utilizamos la clase Random
            Random random = new Random();

            //variables
            const int num_tiros = 36000;

            //array de contador suma
            int[] sumaCont = new int[11];//indice 0-10, 0 representa suma 2, 10 representa suma 12

            //simular lanzamientos
            for (int i = 0; i < num_tiros; i++)
            {
                int dado1 = random.Next(1, 7);//metodo que nos permite manipular numeros aleatorios con un inicio y un limite
                int dado2 = random.Next(1, 7);//en este caso genera un num aleatorio entre 1 y 6
                int suma = dado1 + dado2;//calcular la suma de los dados
     

                //incrementar el contandor segun la suma obtenida
                sumaCont[suma - 2]++;

            }

            //imprimir resultados
            Console.WriteLine("Suma  | Numero de repeticiones");
            for (int suma = 2; suma  <= 12; suma ++)
            {
                Console.WriteLine($"{suma,-5} | {sumaCont[suma - 2]}");
            }

            //verificar resultados
            int frecuenciaSiete = num_tiros / 6;
            Console.WriteLine("Frecuencia esperada para suma 7: " + frecuenciaSiete);//la ligera variación es normal debido a la naturaleza aleatoria de los lanzamientos.
            /*Analisis Resultados
            con respecto a las demas sumas se encuentran en un rango razonable, por ej la suma de 2 y la de 12, son las
            menos frecuentes, lo cual concuerda con la teoria de que hay menos combinaciones posibles para estas sumas
            en comparacion a 7*/

        }
    }
}