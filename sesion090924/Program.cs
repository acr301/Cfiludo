
namespace sesion090924
{
  public class miArreglo
  {
    public void metodoMiArreglo(int nElementos)
    {
      int i;
      int[] arreglo = new int[nElementos];

      for (i = 0; i < nElementos; i++)
      {
        Console.Write("Inserte valor para Arreglo [" + i + "]: ");
        arreglo[i] = Convert.ToInt32(Console.ReadLine());
      }

      // Displaying array
      Console.WriteLine("Elementos arreglo:");
      for (i = 0; i < nElementos; i++)
      {
        Console.WriteLine("Arreglo [" + i + "] = " + arreglo[i]);
      }
    }
  }

  public class miMatriz
  {
    public void metodoMiMatriz(int nFilas, int nCols)
    {
      int[,] matriz = new int[nFilas, nCols];
      int filas;
      int cols;

      for (filas = 0; filas < nFilas; filas++)
      {
        for (cols = 0; cols < nCols; cols++)
        {
          Console.Write("Inserte valor para matriz Matriz [" + filas + "," + cols + "]: ");
          matriz[filas, cols] = Convert.ToInt32(Console.ReadLine());
        }
      }

      // Displaying matrix
      Console.WriteLine("Elementos matriz:");
      for (filas = 0; filas < nFilas; filas++)
      {
        for (cols = 0; cols < nCols; cols++)
        {
          Console.WriteLine("Matriz [" + filas + "," + cols + "] = " + matriz[filas, cols]);
        }
      }
    }

    public class ArreglosParalelos
    {
      // int[nEstudiantes] estudiantes 
      // int[nEstudiantes,]
      public void CalificacionesEstudiantes(int[] estudiantes, int[,] calificaciones)
      {


      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      miArreglo arreglo = new miArreglo();
      miMatriz matriz = new miMatriz();

      Console.WriteLine("Insertando en Arreglo:");
      arreglo.metodoMiArreglo(5);

      Console.WriteLine("Insertando en Matriz:");
      matriz.metodoMiMatriz(3, 3);
    }
  }
}
