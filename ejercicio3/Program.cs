namespace ejercicio3;


/* decido usar foreach en vez de for porque es mas legible
 *
 *
 */

public class Empresa
{
  public class Rangos
  {

    // TO-DO -> hacer los arrays dinamicos
    // en cuanto que se les puedan pasar estos rangos
    int rangoVendedores;

    int rangoVentasDia;
    int rangoVolantesDia;

    int rangoProductos;

    int cantidadDiasMes;
    int rangoVolantesMensual;

  }

  public class Venta
  {
    //4 vendedores
    static string[] vendedores = new string[4] { "Andres", "Emilio", "Gabriel", "Fatima" };


    //productos de 1 a 5
    static string[] productos = new string[5] { "Gaseosa", "Chicle", "Chocolate", "Encendedor", "Recarga" };

    //volante contiene 
    int[][] volante = new int[][] { vendedores, productos };
  }
  public class Volante
  {
    public void VolanteDiario()
    {

    }
    public void VolanteMensual()
    {
      //TO-DO -> que averigue verdaderamente cuantos dias tuvo el mes anterior
      //renglones de producto1 a producto5 y ventasTotalesXvendedorXmes
      //omitiendo venta0, columnas de venta1 a venta4 y ventasTotalesXproductoXmes
      int[,] volanteMensual = new int[6, 5];
    }
  }


}

class Program
{
  static void Main(string[] args)
  {
  }
}
