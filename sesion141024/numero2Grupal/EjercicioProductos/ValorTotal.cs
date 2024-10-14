using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos
{



    public static class Calcular
    {

        public double calcularValorTotal(Producto[] Inventario)
        {
            double valorTotalInventario = 0;
            foreach (var producto in Inventario)
            {
                valorTotalInventario += producto.Precio * producto.CantidadEnStock;
            }

            return valorTotalInventario;
        }
    }
}
