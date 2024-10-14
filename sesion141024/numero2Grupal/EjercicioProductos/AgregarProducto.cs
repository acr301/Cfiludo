using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioProductos
{
    public static class Agregar
    {

        public static bool AgregarProducto()
        {
            bool guardado = false;
            // Pedir al usuario que ingrese los datos del producto
            Write("Ingrese el ID del producto: ");
            int id;
            while (!int.TryParse(ReadLine(), out id))
            {
                WriteLine("ID inválido. Inténtalo de nuevo.");
                Write("Ingrese el ID del producto: ");
            }

            Write("Ingrese el nombre del producto: ");
            string nombre = ReadLine();

            Write("Ingrese el precio del producto: ");
            double precio;
            while (!double.TryParse(ReadLine(), out precio))
            {
                WriteLine("Precio inválido. Inténtalo de nuevo.");
                Write("Ingrese el precio del producto: ");
            }

            Write("Ingrese la cantidad en stock del producto: ");
            int cantidadEnStock;
            while (!int.TryParse(ReadLine(), out cantidadEnStock))
            {
                WriteLine("Cantidad inválida. Inténtalo de nuevo.");
                Write("Ingrese la cantidad en stock del producto: ");
            }

            // Crear un nuevo producto
            Producto nuevoProducto = new Producto(id, nombre, precio, cantidadEnStock);
            guardado = true; 
            return guardado;
        }
    }
}


