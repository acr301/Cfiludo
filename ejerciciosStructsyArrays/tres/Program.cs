namespace tres;

/* Utiliza el struct “Producto” del ejercicio anterior. Modifica el programa para calcular el
precio total de todos los productos en el arreglo y muestra el resultado.
*/

public struct Producto
{
    public int id;
    public string nombre;
    public double precio;

    //constructor para poder realizar la inicializacion implicita simultanea

    public Producto(int ID, string Nombre, double Precio)
    {
        id = ID;
        nombre = Nombre;
        precio = Precio;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Producto[] arregloProductos = new Producto[]
        {
        new Producto(1, "cigarro", 5.0),
        new Producto(2, "encendedor", 3.0),
        new Producto(3, "chicle", 1.9),
        new Producto(4, "chocolate", 2.5),
        new Producto(5, "agua", 1.5),
        };

        double acumuladorPrecios = 0;
        foreach (var producto in arregloProductos)
        {
            acumuladorPrecios += producto.precio;
        }

        Console.WriteLine($" Precio total de los productos en el arreglo: {acumuladorPrecios}");
    }
}
