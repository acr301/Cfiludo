using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using Internal;

namespace EjercicioProductos
{
    public static class Actualizar
    {


        public void ActualizarStock(ref Producto[] inventario, string nombre, int nuevaCantidad)
        {
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i].Nombre == nombre)
                {
                    inventario[i].Cantidad = nuevaCantidad;
                    //inventario[i] = new Producto(nombre, inventario[i].Precio, nuevaCantidad);
                    Console.WriteLine($"Stock actualizado para {nombre}. Nueva cantidad: {nuevaCantidad}");
                    return;
                }
            }
            Console.WriteLine($"Producto {nombre} no encontrado en el inventario.");
        }
    }
}
