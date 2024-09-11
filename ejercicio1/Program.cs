namespace ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====== Calculadora de Tiradas de Dados ======");

        Console.WriteLine("+: Inserte la cantidad de veces que va a tirar los dados (default: 36,000): ");

        int Tiradas;
        while (!int.TryParse(Console.ReadLine() ?? "", out Tiradas)) {
            Console.WriteLine("!: El input no pudo parsearse a entero! Intentelo de nuevo: ");
        }

        int[] Resultados = new int[12];
        int[] ResultadosEsperados = new int[12] {
            0, // 1
            1, // 2
            2, // 3
            3, // 4
            4, // 5
            5, // 6
            6, // 7
            5, // 8
            4, // 9
            3, // 10
            2, // 11
            1  // 12
        };

        // Crear clase del randomizador
        Random Rand = new();
        for(int i = 0; i < Tiradas; i++) {
            // Rand.Next(6) genera numeros enteros del 0 al 5,
            // Agremos 1 para que sea del 1 al 6
            int Random1 = Rand.Next(6) + 1, Random2 = Rand.Next(6) + 1;
            Resultados[Random1 + Random2 - 1]++; 
        }

        Console.WriteLine("==========================================================");
        Console.WriteLine("|Suma\t|Frecuencia\t|Porcentaje\t|Resultado Esperado");
        for (int i = 1; i < Resultados.GetLength(0); i++)
        {
            // Calcular el porcentaje de cada suma
            double Porcentaje = (Resultados[i] / (double) Tiradas) * 100;
            double ResultadoEsperado = Tiradas * ( ResultadosEsperados[i] / 36.0f );

            // Imprimir la suma, su frecuencia y el porcentaje
            Console.WriteLine($"|{i + 1}\t|{Resultados[i]}\t\t|{Porcentaje:0.00}%\t\t|~{ResultadoEsperado:0.00}");
        }
        Console.WriteLine("==========================================================");
    }
}