namespace ejercicio2;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
}

public class ReservacionAerolinea
{
  const int capacidad = 10;
  private int[] asientos;

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

  public class AyudanteInput
  {
    public static int ObtenerEnteroValido(string promptMensaje)
    {
      int resultado;
      Console.WriteLine(promptMensaje);

      while (!int.TryParse(Console.ReadLine(), out resultado))
      {
        Console.WriteLine(" Not a valid seat ");
      }
      return resultado;
    }
    public static int ObtenerEnteroValidoPositivo(string promptMensaje)
    {
      int resultado;
      Console.WriteLine(promptMensaje);

      while (!int.TryParse(Console.ReadLine(), out resultado) || resultado > 0 || resultado <= 10)
      {
        Console.WriteLine(" Not a valid seat ");
      }
      return resultado;
    }

  }
  public void Menu()
  {

  }

}


