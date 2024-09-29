namespace seis;

/*   Modifica el struct “Producto” para incluir un campo CantidadEnStock. Escribe un
programa que busque todos los productos en el arreglo que tienen existencia baja ,es
decir, que la cantidad en stock es menor o igual que 5. Muestre la lista de todos los
productos que cumplen la condición de búsqueda.
*/

public struct Producto
{
    public int id;
    public string nombre;
    public double precio;
    public int cantidadEnStock;
    //constructor para poder realizar la inicializacion implicita simultanea

    public Producto(int ID, string Nombre, double Precio, int CantidadEnStock)
    {

        id = ID;
        nombre = Nombre;
        precio = Precio;
        cantidadEnStock = CantidadEnStock;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Producto[] arregloProductos = new Producto[]
        {
        new Producto(1, "cigarro", 5.0, 150),
        new Producto(2, "encendedor", 3.0, 2),
        new Producto(3, "chicle", 1.9, 1),
        new Producto(4, "chocolate", 2.5, 6),
        new Producto(5, "agua", 1.5, 5),
        };

        // double acumuladorPrecios = 0;
        Console.WriteLine("Hay existencia baja de los siguientes productos: ");
        Console.WriteLine("");
        foreach (var producto in arregloProductos)
        {
            if (producto.cantidadEnStock <= 5)
            {
                Console.WriteLine($" id {producto.id}, nombre {producto.nombre}, precio {producto.precio}, inventario {producto.cantidadEnStock}");
            }
            // acumuladorPrecios += producto.precio;
        }

        // Console.WriteLine($" Precio total de los productos en el arreglo: {acumuladorPrecios}");
    }
}
