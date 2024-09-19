namespace ejercicio2;
using System;

class Program
{
  static void Main(string[] args)
  {
    ReservacionAerolinea reserva = new ReservacionAerolinea();


    int inputUsuarioValidada = AyudanteInput.ObtenerRespuestaValidada();

    // pasar inputUsuarioValidada (1 o 2) al switch del Menu
  }
}

//TO-DO -> Usando banderas, refactorizar validacion input
public class AyudanteInput
{
  public static int ObtenerRespuestaValidada()
  {
    int respuestaValidada;

    string promptUser = @"
    Please type 1 for 'smoking'
    Please type 2 for 'non-smoking'
    ";

    do
    {
      Console.WriteLine(promptUser);
      string inputUsuario = Console.ReadLine();

      if (int.TryParse(inputUsuario, out respuestaValidada) && (respuestaValidada == 1 || respuestaValidada == 2))
      {
        return respuestaValidada;
      }

      Console.WriteLine(" Must be 1 or 2 ");
    } while (true);
  }
}

public class ReservacionAerolinea
{
  const int capacidad = capacidadFumar + capacidadNoFumar;
  const int capacidadFumar = 5;
  const int capacidadNoFumar = 5;

  public int[] asientosOcupados = new int[capacidad];
  private int[] asientosFumar = new int[capacidadFumar];
  private int[] asientosNoFumar = new int[capacidadNoFumar];

  public ReservacionAerolinea()
  {
    InicializarAsientosFumar();
    InicializarAsientosNoFumar();
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

  public int[] Ocupador(int respuesta)
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
        return asientosOcupados;
    }
  }
}

