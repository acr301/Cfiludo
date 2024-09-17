namespace ejercicio3;

// https://introcs.cs.luc.edu/arrays/twodim.html
/* decido usar foreach en vez de for porque es mas legible
 *
 *
 */

public class Empresa
{
  public class Venta
  {
    //4 vendedorespublicstring
    static string[] vendedores = new string[4] { "Andres", "Emilio", "Gabriel", "Fatima" };


    //productos de 1 a 5
    static string[] productos = new string[5] { "Gaseosa", "Chicle", "Chocolate", "Encendedor", "Recarga" };

    //total de productos por dolares por dia
    //5x5 donde el nombre del producto va con su respectivo total diario
    //totalProductosDol[i, 0 ] = numnombreproducto, totalProductosDol[0, j] = totalproductodiariodol
    static int[,] totalProductosDol = new int[5, 5];

    //ventas de supuestos volantes del mes anterior
    //ventas totales por vendedor y producto

    //vendedor [i,] producto [,j]
    int[,] ventas = new int[4, 5];

    //totalizados[0, ] es por producto
    //totalizados[ ,0] es por vendedor
    int[,] totalizados = new int[1, 1];

    public class Rangos
    {
      // TO-DO -> mejorar encapsulacion, usar propiedades para
      // rangos y DRY (do not repeat yourself)
      public int rangoVendedores = vendedores.Length;
      int rangoVentasDia;
      int rangoVolantesDia;

      public int rangoProductos = productos.Length;

      int cantidadDiasMes;
    }
  }
  public class Volante
  {
    public void Diario()
    {

      //cada vendedor entrega por dia entre 0 y 5 volantes
      //cada volante contiene: num vendedor, num producto,
      //valor total en dolares del producto vendido ese dia
      int[,,] volante = new int[4, 5, 5];
    }

    /* ----------------------------ASUMIREMOS QUE LO DE 1 DIA ES LO DE TODO EL MES--------------
     * es decir, volante[,,] = volanteMensual[,,]
     * donde los fors nesteados para lo diario fueron repetidos
     * x cantidad de dias del mes y acumulados en su 
     * totalProductosDolMensual respectivo
    public void Mensual()
    {
      //TO-DO -> que averigue verdaderamente cuantos dias tuvo el mes anterior
      //int[,] volanteMensual = new int[6, 5];
    }
    */
  }

  public class Append
  {
    public void CrearVolanteDiario(int[,,] volante, string[] vendedores, string[] productos, int[,] totalProductosDol)
    {
      int acumuladorTotalProductosDol;

      // append todos los vendedores al indice correspondiente
      for (int i = 0; i < vendedores.Length; i++)
      {
        volante[i, 0, 0] = Array.IndexOf(vendedores, i);

        // append todos los productos al indice correspondiente
        for (int j = 0; j < productos.Length; j++)
        {
          totalProductosDol[j, 0] = Array.IndexOf(productos, j);
          volante[0, j, 0] = Array.IndexOf(productos, j);

          //va sumandolos a un gran total
          acumuladorTotalProductosDol = +totalProductosDol[0, j];

          //este loop era innecesario
          for (int k = 0; k < totalProductosDol.Length; k++)
          {
            volante[0, 0, k] = acumuladorTotalProductosDol;
          }
        }
      }
    }

    // ventas es 4x5
    // volante es 4x5x5
    // totalProductosDol es 5x5
    public void CrearVentas(int[,] totalProductosDol, int[,] ventas, int rangoProductos, int rangoVendedores, int[,,] volante, int[,] totalizados)
    {
      int acumuladorTotalizadoProducto;
      int acumuladorTotalizadoVendedor;

      for (int i = 0; i < rangoVendedores; i++)
      {
        ventas[i, 0] = totalProductosDol
        acumuladorTotalizadoVendedor = +ventas[i, 0];

        for (int j = 0; j < rangoProductos; j++)
        {
          ventas[0, j] =
        }
      }
    }

  }



}

class Program
{
  static void Main(string[] args)
  {
  }
}
