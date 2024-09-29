
namespace siete
{
    public struct Rectangulo//la estructura se declara antes del metodo main
    {
        //miembos
        public double Ancho;
        public double Altura;

        public Rectangulo(double ancho, double altura)
        {//inicializa los miembros de la estrucura
            //constructor
            Ancho = ancho;
            Altura = altura;

        }

        //tiene que retornar un double
        public double calculoArea()
        {
            return (Ancho * Altura);
        }

    }


    public class Geometria
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese la cantidad de rectangulos a procesar: ");
            int cant = int.Parse(Console.ReadLine());

            Rectangulo[] rectangulos = new Rectangulo[cant];//declaramos el arreglo de estructura

            Console.WriteLine("Datos de Rectangulos");
            for (int i = 0; i < rectangulos.Length; i++)
            {
                Console.Write("Ancho: ");
                double ancho = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = int.Parse(Console.ReadLine());

                rectangulos[i] = new Rectangulo(ancho, altura);

            }
            Console.WriteLine("Informacion de Rectangulos");

            for (int i = 0; i < rectangulos.Length; i++)
            {
                double area = rectangulos[i].calculoArea();
                Console.WriteLine($"Rectangulo {i + 1}: Ancho: {rectangulos[i].Ancho}, " +
                    $"Altura: {rectangulos[i].Altura}, Area: {area}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
