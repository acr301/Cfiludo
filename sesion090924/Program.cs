
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

      Console.WriteLine("Elementos matriz:");
      for (filas = 0; filas < nFilas; filas++)
      {
        for (cols = 0; cols < nCols; cols++)
        {
          Console.WriteLine("Matriz [" + filas + "," + cols + "] = " + matriz[filas, cols]);
        }
      }
    }


    public class ArreglosOperaciones
    {

      public void CalificacionesEstudiantes(int nEstudiantes, int nEstudiantesDatos)
      {
        string[,] matrizNotas = new string[nEstudiantes, nEstudiantesDatos];

        int j;
        int contador = 0;


        for (j = 0; j < nEstudiantesDatos; j++)
        {
          int i = 0;
          while (i + 1 < nEstudiantes)
          {
            Console.WriteLine("Inserte valor para [" + i + "," + j + "]: ");
            matrizNotas[i, j] = Console.ReadLine();
            i++;

          }
          contador++;
          Console.WriteLine(" ");
          Console.WriteLine(contador);
        }
      }

      // metodo para mostrar tabular


      class Program
      {
        static void Main(string[] args)
        {
          /*
          miArreglo arreglo = new miArreglo();
          miMatriz matriz = new miMatriz();

          Console.WriteLine("Insertando en Arreglo:");
          arreglo.metodoMiArreglo(5);

          Console.WriteLine("Insertando en Matriz:");
          matriz.metodoMiMatriz(3, 3);
          */

          ArreglosOperaciones calificacionesEstudiantes = new ArreglosOperaciones();
          calificacionesEstudiantes.CalificacionesEstudiantes(2, 3);
        }
      }
    }
  }
}
