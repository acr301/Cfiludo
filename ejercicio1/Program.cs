namespace ejercicio1;
using Ayudantes;

/* Crear un programa que simule la gestión de un inventario en una tienda. Utilizar un menú para
agregar, eliminar, modificar y consultar productos en el inventario. Cada producto tendrá un
código, nombre, cantidad y precio.
Menú de opciones:
1. Agregar producto
2. Eliminar producto
3. Modificar producto
4. Consultar producto
5. Mostrar todos los productos
6. Salir
*/


public struct Producto
{
    public int Codigo;
    public string Nombre;
    public int Cantidad;
    public double Precio;

    public Producto(int codigo, string nombre, int cantidad, double precio) => (Codigo, Nombre, Cantidad, Precio) = (codigo, nombre, cantidad, precio);

    public override string ToString()
    {
        return $"Codigo: {Codigo}, Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio}";
    }
}

public class Inventario
{
    private List<Producto> _productos;

    public Inventario()
    {
        _productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        if (!_productos.Any(p => p.Codigo == producto.Codigo))
        {
            _productos.Add(producto);
            Console.WriteLine($"Producto {producto.Nombre} agregado");
        }
        else
        {
            Console.WriteLine($"Producto con codigo {producto.Codigo} ya existe");
        }
    }

    public void AgregarProductoDesdeInput()
    {
        var positivoDobleValidador = new
          //requerido
          int codigo =
          int nombre =

          //double
          Producto productoNuevo = new Producto();
    }
    public class AgregarProductoAction : IAccion
    {
        public void Ejecutar()
        {
            AgregarProducto();
        }
    }

    public class EliminarProducto : IAccion
    {
        public void Ejecutar()
        {

        }
    }

    public class ModificarProducto : IAccion
    {
        public void Ejecutar()
        {

        }
    }

    public class ConsultarProducto : IAccion
    {
        public void Ejecutar()
        {

        }
    }

    public class MostrarTodos : IAccion
    {
        public void Ejecutar()
        {

        }
    }

    public class Salir : IAccion
    {
        public void Ejecutar()
        {

        }
    }

}


class Program
{
    static void Main(string[] args)
    {
        new SelectorMenu menuProductos = new SelectorMenu();
    }
}
