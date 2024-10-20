namespace trianguloref;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese la base del triangulo: ");
        double baset = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo ");
        double alturat = Convert.ToDouble(Console.ReadLine());

        double res = 0;
        Area(ref baset, ref alturat, ref res);
        Console.WriteLine($"El area del triangulo es: {res}");
        Console.ReadKey();
    }

    public static void Area(ref double x, ref double y, ref double res)
    {
        res = ((x * y) / 2);
    }
}
