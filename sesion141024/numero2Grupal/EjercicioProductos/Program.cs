namespace EjercicioProductos
{
    struct Producto
    {
        public int ID;
        public string Nombre;
        public double Precio;
        public int CantidadEnStock;

        public Producto(int id, string nombre, double precio, int cantidadEnStock)
        {
            ID = id;
            Nombre = nombre;
            Precio = precio;
            CantidadEnStock = cantidadEnStock;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"ID: {ID}, Nombre: {Nombre}, Precio: {Precio:C}, Cantidad en stock: {CantidadEnStock}");
        }
    }

    public class Program
    {
        
        public static void Main()
        {

        }
    }
}