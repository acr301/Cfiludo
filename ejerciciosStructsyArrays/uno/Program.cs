namespace uno;

public struct Estudiante
{
    public string nombre;
    public int edad;
    public double promedio;

}

class Program
{
    static void Main(string[] args)
    {

        Estudiante estudiante1 = new Estudiante();

        estudiante1.nombre = "Andres";
        estudiante1.edad = 32;
        estudiante1.promedio = 99.99;

        Console.WriteLine($"{estudiante1.nombre}, {estudiante1.edad}, {estudiante1.promedio}");
    }
}
