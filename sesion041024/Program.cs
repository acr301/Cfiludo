using System;
using System.IO;

namespace Crud
{
    // Definición de la estructura Producto
    public struct Producto
    {
        public int Id;
        public string Nombre;
        public int Cantidad;
        public decimal Precio;

        // Constructor para inicializar la estructura Producto
        public Producto(int id, string nombre, int cantidad, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }

    public class Crud
    {
        // Constante que representa el nombre del archivo donde se guardarán los productos
        private const string archivo = "productos.dat";

        // Método principal donde se maneja el menú CRUD
        public static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú CRUD ---");
                Console.WriteLine("1. Crear Producto");
                Console.WriteLine("2. Leer Productos");
                Console.WriteLine("3. Actualizar Producto");
                Console.WriteLine("4. Eliminar Producto");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                // Se llama al método correspondiente según la opción seleccionada
                switch (opcion)
                {
                    case 1: AgregarProducto(); break;
                    case 2: LeerProductos(); break;
                    case 3: ActualizarProducto(); break;
                    case 4: EliminarProducto(); break;
                    case 5: break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            } while (opcion != 5);
        }

        // Método para agregar un nuevo producto
        public static void AgregarProducto()
        {
            Console.Write("Ingrese el ID del producto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Producto producto = new Producto(id, nombre, cantidad, precio);

            // Guardar el nuevo producto en el archivo utilizando BinaryWriter
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Append)))
            {
                writer.Write(producto.Id);
                writer.Write(producto.Nombre);
                writer.Write(producto.Cantidad);
                writer.Write(producto.Precio);
            }

            Console.WriteLine("Producto agregado exitosamente.");
        }

        // Método para leer y mostrar todos los productos del archivo
        public static void LeerProductos()
        {
            // Comprobar si el archivo existe
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay productos para mostrar.");
                return;
            }

            // Leer el archivo con BinaryReader y mostrar los productos
            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            {
                Console.WriteLine("\nProductos");
                try
                {
                    // Leer cada producto hasta llegar al final del archivo
                    while (true)
                    {
                        Producto producto = new Producto()
                        {
                            Id = reader.ReadInt32(),
                            Nombre = reader.ReadString(),
                            Cantidad = reader.ReadInt32(),
                            Precio = reader.ReadDecimal()
                        };
                        Console.WriteLine($"ID: {producto.Id}");
                        Console.WriteLine($"Nombre: {producto.Nombre}");
                        Console.WriteLine($"Cantidad: {producto.Cantidad}");
                        Console.WriteLine($"Precio: {producto.Precio}");
                        Console.WriteLine();
                    }
                }
                catch (EndOfStreamException) { }
            }
        }

        // Método para actualizar un producto existente
        public static void ActualizarProducto()
        {
            Console.Write("Ingrese el ID del producto: ");
            int idBuscado = int.Parse(Console.ReadLine());
            bool encontrado = false;
            string archivo_temp = "temporal.dat"; // Archivo temporal para realizar la actualización

            // Lectura y escritura en archivos: leer desde el archivo original, escribir en archivo temporal
            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo_temp, FileMode.Create)))
            {
                try
                {
                    // Leer cada producto del archivo
                    while (true)
                    {
                        Producto producto = new Producto()
                        {
                            Id = reader.ReadInt32(),
                            Nombre = reader.ReadString(),
                            Cantidad = reader.ReadInt32(),
                            Precio = reader.ReadDecimal()
                        };

                        // Si el producto coincide con el ID buscado, se actualiza
                        if (producto.Id == idBuscado)
                        {
                            Console.Write("Ingrese el nuevo nombre: ");
                            producto.Nombre = Console.ReadLine();
                            Console.Write("Ingrese la nueva cantidad: ");
                            producto.Cantidad = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el nuevo precio: ");
                            producto.Precio = decimal.Parse(Console.ReadLine());
                            encontrado = true;
                        }

                        // Escribir el producto (actualizado o no) en el archivo temporal
                        writer.Write(producto.Id);
                        writer.Write(producto.Nombre);
                        writer.Write(producto.Cantidad);
                        writer.Write(producto.Precio);
                    }
                }
                catch (EndOfStreamException) { } // Capturar excepción al llegar al final del archivo
            }

            // Reemplazar el archivo original por el archivo temporal actualizado
            File.Delete(archivo);
            File.Move(archivo_temp, archivo);

            // Mostrar el resultado de la operación
            if (encontrado)
                Console.WriteLine("El producto fue exitosamente actualizado.");
            else
                Console.WriteLine("El producto no fue encontrado.");
        }

        // Método para eliminar un producto
        //para eliminar se usan dos archivos
        public static void EliminarProducto()
        {
            Console.Write("Ingrese el ID del producto: ");
            int idBuscado = int.Parse(Console.ReadLine());
            bool encontrado = false;
            string archivo_temp = "temporal.dat"; // Archivo temporal para realizar la actualización

            // Lectura y escritura en archivos: leer desde el archivo original, escribir en archivo temporal
            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo_temp, FileMode.Create)))
            {
                try
                {

                    while (true)
                    {
                        Producto producto = new Producto()
                        {
                            Id = reader.ReadInt32(),
                            Nombre = reader.ReadString(),
                            Cantidad = reader.ReadInt32(),
                            Precio = reader.ReadDecimal()
                        };

                        // Si el producto coincide con el ID buscado, se actualiza
                        //break sale del bucle
                        //continue solo lo salta, omite
                        if (producto.Id == idBuscado)//no hay opcion de eliminar
                        {
                            encontrado = true;
                            continue;//para no tomarlo en cuenta, hace el salta y no lo toma en cuenta

                        }

                        // Escribir el producto (actualizado o no) en el archivo temporal
                        writer.Write(producto.Id);
                        writer.Write(producto.Nombre);
                        writer.Write(producto.Cantidad);
                        writer.Write(producto.Precio);
                    }
                }
                catch (EndOfStreamException) { } // Capturar excepción al llegar al final del archivo
            }

            // Reemplazar el archivo original por el archivo temporal actualizado
            File.Delete(archivo);
            File.Move(archivo_temp, archivo);

            // Mostrar el resultado de la operación
            if (encontrado)
                Console.WriteLine("El producto fue elimninado exitosamente.");
            else
                Console.WriteLine("El producto no fue encontrado.");
        }

    }
}
