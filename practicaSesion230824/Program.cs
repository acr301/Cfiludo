using System;


//toma en cuenta que Console.ReadLine() solo toma char/string
//toca hacer un casteo

namespace Empleado
{
  public class EmpleadoClase
  {
    public int codigo;
    public string nombre;
    public string apellido;
    public string cargo;
    public float salario;
    public char sexo;
    public bool capacitacion;

    public void EscribirDatosEmpleado()
    {
      Console.Write("Datos de empleado: ");
      Console.WriteLine(" ");

      Console.WriteLine("Inserte el código: ");
      codigo = int.Parse(Console.ReadLine());

      Console.WriteLine("Inserte el nombre: ");
      nombre = Console.ReadLine();

      Console.WriteLine("Inserte el cargo: ");
      cargo = Console.ReadLine();

      Console.WriteLine("Inserte los apellidos: ");
      apellido = Console.ReadLine();

      Console.WriteLine("Inserte el salario: ");
      salario = float.Parse(Console.ReadLine());

      Console.WriteLine("Inserte el sexo: (F/M)");
      //sexo = char.Parse(Console.ReadLine().ToUpper());
      string sexoRespuesta = Console.ReadLine().ToUpper();
      sexo = char.Parse(sexoRespuesta);

      if (sexoRespuesta.Length == 1 && (sexoRespuesta[0] == 'F' || sexoRespuesta[0] == 'M'))
      {
        sexo = sexoRespuesta[0];
      }
      else
      {
        Console.WriteLine("Sexo inválido, debe ser 'F' o 'M'");
      }


      Console.WriteLine("¿Es anuente a capacitación? Contestar (si/no): ");
      string capacitacionRespuesta = Console.ReadLine().ToLower();
      if (capacitacionRespuesta == "si")
      {
        capacitacion = true;
      }
      else if (capacitacionRespuesta == "no")
      {
        capacitacion = false;
      }
      else
      {
        Console.WriteLine("Respuesta invalida, contestar 'si' o 'no': ");
      }


    }
    public void LeerDatosEmpleado()
    {
      Console.WriteLine(" ");
      Console.Write("Datos de empleado: ");
      Console.WriteLine(" ");
      Console.WriteLine("Código: " + codigo);
      Console.WriteLine("Nombre: " + nombre);
      Console.WriteLine("Apellido: " + apellido);
      Console.WriteLine("Cargo: " + cargo);
      Console.WriteLine("Salario: " + salario);
      Console.WriteLine("Sexo: " + sexo);


      if (capacitacion == true)
      {
        Console.WriteLine("Capacitación No Anuente");
      }
      else
      {
        if (capacitacion == false)
        {
          Console.WriteLine("Capacitación: No Anuente");
        }
      }
      Console.ReadKey();
    }

  }

  public class ValidacionEmpleado : EmpleadoClase
  {
    /* aquí debería ir un error handling, de manera que los atributos
     * insertados sean consistentes, esperados, manipulables
     * y consecuentes la abstracción de la clase Empleado
     * considerando que el que inserte un empelado solo dispone de 
     * una simple consola 
     *
     * para que no hayan M, m, F, f, para que no inserten locuritas que
     * crasheen el progama a
     *
     * */
  }

  class Programa
  {
    static void Main(string[] args)
    {
      EmpleadoClase empleado1 = new EmpleadoClase();

      empleado1.EscribirDatosEmpleado();
      empleado1.LeerDatosEmpleado();
    }
  }
}

