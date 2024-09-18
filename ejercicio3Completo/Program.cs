namespace ejercicio3Completo;


using System;

public class ReporteVentas
{
  private string[] vendedores = new string[4];
  private string[] productos = new string[5];
  private int[][][] volantesAcumulado;
  private int[,] ventas;
  private int[] ventasTotalesPorVendedor;
  private int[] ventasTotalesPorProducto;

  private Random random = new Random();

  public ReporteVentas()
  {
    InicializarVendedores();
    InicializarProductos();
    volantesAcumulado = new int[30][][];
    ventas = new int[vendedores.Length, productos.Length];
    ventasTotalesPorVendedor = new int[vendedores.Length];
    ventasTotalesPorProducto = new int[productos.Length];
  }

  private void InicializarVendedores()
  {
    vendedores[0] = "Cesar";
    vendedores[1] = "Andres";
    vendedores[2] = "Emilio";
    vendedores[3] = "Fatima";
  }

  private void InicializarProductos()
  {
    productos[0] = "Laptops";
    productos[1] = "Phones";
    productos[2] = "Tablets";
    productos[3] = "Monitors";
    productos[4] = "Headphones";
  }

  private int ObtenerVentasAleatorias(string producto)
  {
    switch (producto)
    {
      case "Laptops": return random.Next(1000, 2000);
      case "Phones": return random.Next(500, 1000);
      case "Tablets": return random.Next(300, 700);
      case "Monitors": return random.Next(200, 500);
      case "Headphones": return random.Next(50, 150);
      default: return random.Next(100, 500);
    }
  }

  public void GenerarVolantesAcumulado()
  {
    for (int dia = 0; dia < 30; dia++)
    {
      volantesAcumulado[dia] = new int[vendedores.Length][];

      for (int indiceVendedor = 0; indiceVendedor < vendedores.Length; indiceVendedor++)
      {
        int volantesContador = random.Next(0, 6);
        volantesAcumulado[dia][indiceVendedor] = new int[volantesContador * 2];

        for (int i = 0; i < volantesContador; i++)
        {
          int indiceProducto = random.Next(0, productos.Length);
          int ventasValor = ObtenerVentasAleatorias(productos[indiceProducto]);

          volantesAcumulado[dia][indiceVendedor][i * 2] = indiceProducto;
          volantesAcumulado[dia][indiceVendedor][i * 2 + 1] = ventasValor;

          ventas[indiceVendedor, indiceProducto] += ventasValor;
          ventasTotalesPorVendedor[indiceVendedor] += ventasValor;
          ventasTotalesPorProducto[indiceProducto] += ventasValor;
        }
      }
    }
  }

  public void MostrarTabularVentas()
  {
    Console.WriteLine("\nTotal ventas del mes:");
    Console.Write("           ");
    for (int i = 0; i < productos.Length; i++)
    {
      Console.Write($"{productos[i],-12}");
    }
    Console.WriteLine("Total");

    for (int i = 0; i < vendedores.Length; i++)
    {
      Console.Write($"{vendedores[i],-10}");
      for (int j = 0; j < productos.Length; j++)
      {
        Console.Write($"{ventas[i, j],-12}");
      }
      Console.WriteLine($"{ventasTotalesPorVendedor[i],-12}");
    }

    Console.Write("Total     ");
    for (int j = 0; j < productos.Length; j++)
    {
      Console.Write($"{ventasTotalesPorProducto[j],-12}");
    }
    Console.WriteLine();
  }
}

public class Program
{
  public static void Main()
  {
    ReporteVentas report = new ReporteVentas();
    report.GenerarVolantesAcumulado();
    report.MostrarTabularVentas();
  }
}
