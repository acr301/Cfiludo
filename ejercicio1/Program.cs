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
}

public class Inventario
{
    public Producto Articulo;
    public Inventario(Producto articulo) => (Articulo) = (articulo);
}

public class AgregarProducto : IAccion
{
    public void Ejecutar()
    {

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



class Program
{
    static void Main(string[] args)
    {



    }
}
