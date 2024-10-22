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
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    public Producto(string codigo, string nombre, int cantidad, double precio) => (Codigo, Nombre, Cantidad, Precio) = (codigo, nombre, cantidad, precio);

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

    public class OperacionesInventario
    {

        public List<Producto> listaProductos = new List<Producto>();
        public ProductoInputHandler inputHandler = new ProductoInputHandler();


        public void AgregarProducto()
        {
            Console.WriteLine("\nAgregando nuevo producto...");

            string codigo;
            do
            {
                codigo = inputHandler.ObtenerCodigoValidado();
                if (ProductoExiste(codigo))
                {
                    Console.WriteLine($"Producto con codigo {codigo} ya existe. Inserte un codigo distinto");
                }
            } while (ProductoExiste(codigo));


        }

        public void EliminarProducto()
        {
            Console.WriteLine("\nEliminando un producto...");

            string codigo = inputHandler.ObtenerCodigoValidado();
            Producto? producto = EncontrarProductoPorCodigo(codigo);

            if (producto != null)
            {
                listaProductos.Remove(producto.Value);
                Console.WriteLine("Producto eliminado.\n");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.\n");
            }
        }



        // encuentra producto por su codigo
        public Producto? EncontrarProductoPorCodigo(string codigo)
        {
            foreach (var producto in listaProductos)
            {
                if (producto.Codigo == codigo)
                {
                    return producto;
                }
            }
            return null;
        }

        public void MostrarProducto()
        {
            Console.WriteLine("\nMostrando detalles de producto...");

            string codigo = inputHandler.ObtenerCodigoValidado();
            Producto? producto = EncontrarProductoPorCodigo(codigo);

            if (producto != null)
            {
                Console.WriteLine(producto.Value);
            }
            else
            {
                Console.WriteLine("Producto no encontrado\n");
            }
        }

        public void ModificarProducto()
        {
            Console.WriteLine("\nModificando un producto");

            string codigo = inputHandler.ObtenerCodigoValidado();
            Producto? producto = EncontrarProductoPorCodigo(codigo);

            if (producto != null)
            {
                Console.WriteLine($"Producto encontrado: {producto.Value}");
                Console.WriteLine("Que campo desea modificar?");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Cantidad");
                Console.WriteLine("3. Precio");

                int opcion;
                do
                {
                    Console.WriteLine("escriba su eleccion (1-3): ");
                } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3);

                switch (opcion)
                {
                    case 1:
                        string nuevoNombre = inputHandler.ObtenerNombreValidado();
                        ActualizarProducto(producto.Value, nuevoNombre, producto.Value.Cantidad, producto.Value.Precio);
                        break;
                    case 2:
                        int nuevaCantidad = inputHandler.ObtenerCantidadValidada();
                        ActualizarProducto(producto.Value, producto.Value.Nombre, nuevaCantidad, producto.Value.Precio);
                        break;
                    case 3:
                        double nuevoPrecio = inputHandler.ObtenerPrecioValidado();
                        ActualizarProducto(producto.Value, producto.Value.Nombre, producto.Value.Cantidad, nuevoPrecio);
                        break;
                }
                Console.WriteLine(" Producto modificado.\n ");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.\n");
            }
        }
        public void MostrarTodos()
        {
            Console.WriteLine("\nMostrando todos los productos...");
            if (listaProductos.Count == 0)
            {
                Console.WriteLine("No hay productos aun.\n");
            }
            else
            {
                foreach (var producto in listaProductos)
                {
                    Console.WriteLine(producto);
                }
            }
        }

        // si fue encontrado, tener ese criterio true o false
        public bool ProductoExiste(string codigo)
        {
            return EncontrarProductoPorCodigo(codigo) != null;
        }

        // metodo que actualiza producto (sobreescribiendolo)
        // porque es un struct, de tipo valor entonces
        public void ActualizarProducto(Producto productoAnterior, string nuevoNombre, int nuevaCantidad, double nuevoPrecio)
        {
            Producto productoActualizado = new Producto(productoAnterior.Codigo, nuevoNombre, nuevaCantidad, nuevoPrecio);
            int indice = listaProductos.IndexOf(productoAnterior);
            listaProductos[indice] = productoActualizado;
        }
    }

    public class ProductoInputHandler
    {
        public Producto ObtenerInputProducto()
        {
            string codigo = ObtenerCodigoValidado();
            string nombre = ObtenerNombreValidado();
            int cantidad = ObtenerCantidadValidada();
            double precio = ObtenerPrecioValidado();

            return new Producto(codigo, nombre, cantidad, precio);
        }

        public string ObtenerCodigoValidado()
        {
            string codigo;
            Validador<string> validador = new Validador<string>()
              .AgregarRegla(input => AyudanteValidacion.ValidarRequeridoString(input, "Codigo"));

            do
            {
                Console.Write("Escriba codigo de producto ");
                codigo = Console.ReadLine();
                var resultado = validador.Validacion(codigo);

                if (!resultado.esValido)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, resultado.MensajesError));
                }

            } while (!validador.Validacion(codigo).esValido);

            return codigo;
        }

        public string ObtenerNombreValidado()
        {
            string nombre;
            Validador<string> validador = new Validador<string>()
              .AgregarRegla(input => AyudanteValidacion.ValidarRequeridoString(input, "Nombre"));

            do
            {
                Console.Write("Inserte nombre de producto: ");
                nombre = Console.ReadLine();
                var resultado = validador.Validacion(nombre);

                if (!resultado.esValido)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, resultado.MensajesError));
                }
            } while (!validador.Validacion(nombre).esValido);
            return nombre;
        }

        public int ObtenerCantidadValidada()
        {
            int? cantidad;
            Validador<int?> validador = new Validador<int?>()
              .AgregarRegla(value => AyudanteValidacion.ValidarRequeridoEntero(value, "Cantidad"));

            do
            {
                Console.Write("Inserte cantidad de producto: ");
                string input = Console.ReadLine();

                var resultado = validador.Validacion(int.TryParse(input, out int cantidadTemporal) ? (int?)cantidadTemporal : null);
                if (!resultado.esValido)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, resultado.MensajesError));
                    cantidad = null; // para que se revalide
                }
                else
                {
                    cantidad = cantidadTemporal;
                }
            } while (!validador.Validacion(cantidad).esValido); // re -checkear validacion

            return cantidad.Value;
        }

        public double ObtenerPrecioValidado()
        {
            double? precio;
            Validador<double?> validador = new Validador<double?>()
              .AgregarRegla(value => AyudanteValidacion.ValidarRequeridoDoblePositivo(value, "Precio"));

            do
            {
                Console.Write("Inserte nombre de producto: ");
                string input = Console.ReadLine();
                var resultado = validador.Validacion(double.TryParse(input, out double precioTemporal) ? (double?)precioTemporal : null);

                if (!resultado.esValido)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, resultado.MensajesError));
                    precio = null;
                }
                else
                {
                    precio = precioTemporal;
                }
            } while (!validador.Validacion(precio).esValido);
            return precio.Value;
        }

    }
}



public class AgregarProductoAccion : IAccion
{
    private Inventario.OperacionesInventario _operaciones;

    public AgregarProductoAccion(Inventario.OperacionesInventario operaciones)
    {
        _operaciones = operaciones;
    }

    public void Ejecutar()
    {
        _operaciones.AgregarProducto();
    }

    public string Descripcion => "Agregar nuevo producto";
}

public class EliminarProductoAccion : IAccion
{
    private Inventario.OperacionesInventario _operaciones;

    public EliminarProductoAccion(Inventario.OperacionesInventario operaciones)
    {
        _operaciones = operaciones;
    }
    public void Ejecutar()
    {
        _operaciones.EliminarProducto();
    }
    public string Descripcion => "Eliminar un producto";
}

public class ModificarProductoAccion : IAccion
{

    private Inventario.OperacionesInventario _operaciones;

    public ModificarProductoAccion(Inventario.OperacionesInventario operaciones)
    {
        _operaciones = operaciones;
    }
    public void Ejecutar()
    {
        _operaciones.ModificarProducto();
    }
    public string Descripcion => "Modificar un producto";
}

public class ConsultarProductoAccion : IAccion
{

    private Inventario.OperacionesInventario _operaciones;

    public ConsultarProductoAccion(Inventario.OperacionesInventario operaciones)
    {
        _operaciones = operaciones;
    }
    public void Ejecutar()
    {
        _operaciones.MostrarProducto();
    }
    public string Descripcion => "Muestra un producto";
}

public class MostrarTodosAccion : IAccion
{

    private Inventario.OperacionesInventario _operaciones;

    public MostrarTodosAccion(Inventario.OperacionesInventario operaciones)
    {
        _operaciones = operaciones;
    }
    public void Ejecutar()
    {
        _operaciones.MostrarTodos();
    }
    public string Descripcion => "Muestra todos los productos";
}

public class Salir : IAccion
{
    public void Ejecutar()
    {

    }
}

public class MenuProducto
{
    private Inventario.OperacionesInventario operacionesInventario;
    private SelectorMenu menu;

    public MenuProducto()
    {
        operacionesInventario = new Inventario.OperacionesInventario();

        List<Opcion> opciones = new List<Opcion>
        {
        new Opcion("Agregar Producto", new AgregarProductoAccion(operacionesInventario)),
        new Opcion("Eliminar Producto", new EliminarProductoAccion(operacionesInventario)),
        new Opcion("Modificar Producto", new ModificarProductoAccion(operacionesInventario)),
        new Opcion("Consultar Producto", new ConsultarProductoAccion(operacionesInventario)),
        new Opcion("Mostrar todos los productos", new MostrarTodosAccion(operacionesInventario)),
        new Opcion("Salir", new AccionSalir())
    };

        menu = new SelectorMenu(opciones);
    }
    public void Correr()
    {
        menu.MenuMostrar();
    }
}


class Program
{
    static void Main(string[] args)
    {
        MenuProducto menuProducto = new MenuProducto();

        menuProducto.Correr();
    }
}
