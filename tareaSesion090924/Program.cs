namespace tareaSesion090924;

using System;

public class ArreglosOperaciones
{
  public void CalificacionesEstudiantes(int nEstudiantes, int nCortes)
  {
    string[] nombres = new string[nEstudiantes];
    double[,] notas = new double[nEstudiantes, nCortes];
    double[] promedios = new double[nEstudiantes];

    // Capturar nombres y notas
    for (int i = 0; i < nEstudiantes; i++)
    {
      Console.WriteLine($"Inserte el nombre del estudiante {i + 1}: ");
      nombres[i] = Console.ReadLine();

      double sumaNotas = 0;
      for (int j = 0; j < nCortes; j++)
      {
        Console.WriteLine($"Inserte la nota del corte {j + 1} para {nombres[i]}: ");
        notas[i, j] = double.Parse(Console.ReadLine());
        sumaNotas += notas[i, j];
      }

      // Calcular promedio
      promedios[i] = sumaNotas / nCortes;
    }

    // Mostrar resultados en formato tabular
    Console.WriteLine("\nNombre - Nota1 - Nota2 - Nota3 - Promedio");
    for (int i = 0; i < nEstudiantes; i++)
    {
      Console.Write($"{nombres[i]} - ");
      for (int j = 0; j < nCortes; j++)
      {
        Console.Write($"{notas[i, j]} - ");
      }
      Console.WriteLine($"{promedios[i]:F2}");
    }
  }
}

// Uso del método
class Program
{
  static void Main(string[] args)
  {
    ArreglosOperaciones operaciones = new ArreglosOperaciones();
    operaciones.CalificacionesEstudiantes(3, 3);
  }
}
