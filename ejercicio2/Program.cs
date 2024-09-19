namespace ejercicio2;
using System;

class Program
{
  static void Main(string[] args)
  {
    ReservacionAerolinea reserva = new ReservacionAerolinea();

    string textoMenu = @"Please type 1 for 'smoking'
    Please type 2 for 'non-smoking'";

    int enteroValidado = AyudanteInput.ParsearEntero();
    Console.Write(enteroValidado);
  }
}

//TO-DO -> Usando banderas, refactorizar validacion input
public class AyudanteInput
{
  /*
   public static int ObtenerEnteroValido(string promptMensaje)
   {
     int resultado;
    // Console.WriteLine(promptMensaje);

    while (!int.TryParse(Console.ReadLine(), out resultado))
    {
      Console.WriteLine(" Not a valid seat ");
    }
      return resultado;
    }
    */


  // validacion de tipo y rango dentro de array
  public static int ParsearEntero()
  {
    int numero;
    /* si inputNumero distinto a 1 o 2
    int resultado;
    while (!int.TryParse(Console.ReadLine(), out resultado))
    {
      Console.WriteLine(" Not a valid answer ");
    }
    */
    while (true)
    {
      Console.Clear();
      Console.WriteLine("escribe 1 si fuma, 2 si no fuma");
      if (!int.TryParse(Console.ReadLine(), out numero) || (numero != 1 && numero != 2))
      {
        Console.WriteLine("invalid option");
        Console.ReadKey();
        Console.Clear();
      }
      else
      {
        return numero;
      }
      break;
    }
    return 0;
  }
}

public class ReservacionAerolinea
{
  const int capacidad = capacidadFumar + capacidadNoFumar;
  const int capacidadFumar = 5;
  const int capacidadNoFumar = 5;
  private int[] asientos = new int[capacidad];
  public int[] asientosOcupados = new int[capacidad];
  private int[] asientosFumar = new int[capacidadFumar];
  private int[] asientosNoFumar = new int[capacidadNoFumar];

  public ReservacionAerolinea()
  {
    InicializarAsientos();
    InicializarAsientosFumar();
    InicializarAsientosNoFumar();
  }
  private void InicializarAsientos()
  {
    asientos[0] = 1;
    asientos[1] = 2;
    asientos[2] = 3;
    asientos[3] = 4;
    asientos[4] = 5;
    asientos[5] = 6;
    asientos[6] = 7;
    asientos[7] = 8;
    asientos[8] = 9;
    asientos[9] = 10;
  }
  private void InicializarAsientosFumar()
  {
    asientosFumar[0] = 1;
    asientosFumar[1] = 2;
    asientosFumar[2] = 3;
    asientosFumar[3] = 4;
    asientosFumar[4] = 5;
  }
  private void InicializarAsientosNoFumar()
  {
    asientosNoFumar[0] = 6;
    asientosNoFumar[1] = 7;
    asientosNoFumar[2] = 8;
    asientosNoFumar[3] = 9;
    asientosNoFumar[4] = 10;
  }

  public int[] OcuparAsientosFumar()
  {
    for (int i = 0; i < 1; i++)
    {
      int ocuparFumar = capacidadFumar - i;
      asientosOcupados[i] = asientosFumar[ocuparFumar];
    }
    return asientosOcupados;
  }

  public int[] OcuparAsientosNoFumar()
  {
    for (int i = 0; i < 1; i++)
    {
      int ocuparNoFumar = capacidadNoFumar - i;
      asientosOcupados[i] = asientosNoFumar[ocuparNoFumar];
    }
    return asientosOcupados;
  }

  public int[] Menu(int respuesta)
  {
    switch (respuesta)
    {
      case 1:
        int[] ocupadosFumar = OcuparAsientosFumar();
        return ocupadosFumar;
      case 2:
        int[] ocupadosNoFumar = OcuparAsientosNoFumar();
        return ocupadosNoFumar;
      default:
        return asientos;
    }
  }
}

