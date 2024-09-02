namespace practicaSesion300824;
using System;

class Program
{
  public class Libro
  {
    public string titulo;
    public string autor;

    int numeroPaginas;
    float precio;

    bool disponibilidad;

    int publicacion;

    public class LibroGestion
    {
      public string stringEscrita;
      public string stringAInscribir;
      public bool resultado;
      public string advertenciaUser;
      public int numeroEscrito;
      public float numeroEscritof;

      public bool validarString(string stringEscrita)
      {
        if (string.IsNullOrEmpty(stringEscrita))
        {
          resultado = false;
        }
        else
        {
          resultado = true;
        }
        return resultado;
      }

      public bool validarInt(string stringEscrita)
      {
        resultado = int.TryParse(stringEscrita, out stringAInscribir);
        return resultado;
      }
      public bool validarFloat(float numeroEscritof)
      {
        resultado = float.TryParse(numeroEscritof, out stringAInscribir);
        return resultado;
      }
    }

  }
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
}
