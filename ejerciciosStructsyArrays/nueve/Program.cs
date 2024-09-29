namespace nueve;

/* Define un struct llamado “Coche” con campos para Marca, Modelo, y Año. Escribe un
programa que permita al usuario ingresar la información para varios coches, almacene
los datos en un arreglo, y luego muestre todos los coches ingresados.
*/

public struct Coche
{
    public string Marca;
    public string Modelo;
    public string Anio;

    public Coche(string marca, string modelo, string anio)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Cuantos coches desea ingresar?");
        int nCoches = Int32.Parse(Console.ReadLine());


        Coche[] coches = new Coche[nCoches];


        for (int i = 0; i < coches.Length; i++)
        {
            Console.Write(" Marca: ");
            string marcaCoche = Console.ReadLine();

            Console.Write(" Modelo: ");
            string modeloCoche = Console.ReadLine();

            Console.Write(" Año: ");
            string modeloAnio = Console.ReadLine();

            coches[i] = new Coche(marcaCoche, modeloCoche, modeloAnio);
        }

        for (int i = 0; i < coches.Length; i++)
        {
            Console.WriteLine($"Coche {i + 1}: Marca: {coches[i].Marca}, Modelo: {coches[i].Modelo}, Año: {coches[i].Anio}");
        }
    }
}
