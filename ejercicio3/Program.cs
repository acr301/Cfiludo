using System;

namespace Ejercicio3
{
    public class Programa
    {
        static void Main(string[] agrs)
        {
            /*
             * Programa para procesar y resumir ventas de una empresa con 4 vendedores y 5 productos.
             * - Utiliza un arreglo bidimensional `sales` para almacenar ventas.
             * - Lee la información de volantes del mes anterior.
             * - Resume y muestra ventas por vendedor y producto en formato tabular.
             * - Incluye totales por producto y por vendedor en la tabla.*/
             
            //crear arrays
            //array bidimensional sales
            int[,] sales = new int[4, 5];//se incializa en 0 por defecto

            Console.WriteLine("Informacion correspondiente a las ventas del mes anterior");
            Console.WriteLine();

            //simulacion volantes del mes pasado
            //suponer que se tiene la info en un arreglo llamando volanteVentas
            //contiene (num vendedor, num producto, valor total venta)
            //recordar que estamos trabajando con tipos anónimos, ya que no tienen nombres.
            var volanteVentas = new (int numeroVendedor, int numeroProducto, int valorVenta)[]
            {
                (1, 1, 100),  //vendedor 1 vendió 100 del Producto 1
                (2, 1, 150),  //vendedor 2 vendió 150 del Producto 1
                (1, 2, 200),  //vendedor 1 vendió 200 del Producto 2
                (3, 2, 250),  //vendedor 3 vendió 250 del Producto 2
                (4, 3, 300)   //vendedor 4 vendió 300 del Producto 3
            };

            //procesar cada volante de venta
            foreach (var volante in volanteVentas)
            {
                int vendedor = volante.numeroVendedor;
                int producto = volante.numeroProducto;
                int valorVenta = volante.valorVenta;

                //actualizar arreglo "sales" con el valor de la venta
                sales[vendedor - 1, producto - 1] += valorVenta;
            }

            //imprimir resultados
            Console.WriteLine("Producto\tVendedor 1\tVendedor 2\tVendedor 3\tVendedor 4\tTotal");

            //recorrer cada producto
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Producto {i + 1}\t");//\t, alinea los datos en columnas separadas por tabulaciones
                int totalProducto = 0;

                // recorrer cada vendedor para el producto actual
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{sales[j, i]}\t\t");
                    totalProducto += sales[j, i];
                }

                //imprimir el total de ventas para el producto actual
                Console.WriteLine(totalProducto);
            }

            //imprimir los totales de cada vendedor
            Console.Write("Total\t\t");

            //recorrer cada vendedor
            for (int j = 0; j < 4; j++)
            {
                int totalVendedor = 0;

                //sumar las ventas de cada producto para el vendedor actual
                for (int i = 0; i < 5; i++)
                {
                    totalVendedor += sales[j, i];
                }

                //mostrar el total
                Console.Write($"{totalVendedor}\t\t");
            }

            //imprimir el total general de todos los productos y vendedores
            Console.WriteLine();

            int totalacumulado = 0;
            for (int i = 0; i < 5; i++)
            {
                int totalProducto = 0;
                for (int j = 0; j < 4; j++)
                {
                    totalProducto += sales[j, i];
                }
                totalacumulado += totalProducto;
            }

            Console.WriteLine($"Total Acumulado\t{totalacumulado}");
            Console.ReadKey();
        }
    }
}