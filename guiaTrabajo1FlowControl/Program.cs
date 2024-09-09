namespace guiaTrabajo1FlowControl;


public class Par
{
  public bool esPar
  { get; private set; }

  public void VerificarEsPar(int numero)
  {
    esPar = (numero % 2 == 0);
  }
}

public class MultiplosTres
{
  public int[] ObtenerMultiplosTres(int n)
  {
    //clase List
    List<int> multiplos = new List<int>();

    for (int i = 3; i <= n; i += 3)
    {
      //metodo de clase List que appendea 
      multiplos.Add(i);
    }

    //metodo que convierte lista a arreglo
    return multiplos.ToArray();
  }
}

public class EncontrarFactorial
{
  public long ObtenerFactorial(int n)
  {
    long factorial = 1;

    for (int i = 2; i <= n; i++)
    {
      factorial *= i;
    }
    return factorial;
  }
}

public class EncontrarFibonacci
{
  public void ImprimirSerieFibonacci(int n)
  {
    long primero = 0, segundo = 1, siguiente;

    Console.WriteLine("Serie Fibonacci hasta el termino a sub " + n + ": ");

    for (int i = 1; i <= n; i++)
    {
      if (i == 1)
      {
        Console.WriteLine(primero);
        continue;
        //document this keyword
      }
      if (i == 2)
      {
        Console.WriteLine(segundo);
        continue;
      }

      siguiente = primero + segundo;
      Console.WriteLine(siguiente);
      primero = segundo;
      segundo = siguiente;
    }
  }
}

public class AyudanteInput
{
  public static int ObtenerEnteroValido(string promptMensaje)
  {
    int resultado;
    Console.WriteLine(promptMensaje);

    while (!int.TryParse(Console.ReadLine(), out resultado))
    {
      Console.WriteLine(" eso no es un entero :( ");
    }
    return resultado;
  }

  public static int ObtenerEnteroValidoPositivo(string promptMensaje)
  {
    int resultado;
    Console.WriteLine(promptMensaje);

    while (!int.TryParse(Console.ReadLine(), out resultado) || resultado <= 0)
    {
      Console.WriteLine(" eso no es un entero positivo :( ");
    }
    return resultado;
  }
}

class Program
{
  static void Main(string[] args)
  {


    Par checkearPar = new Par();
    int userNumeroCheckearPar = AyudanteInput.ObtenerEnteroValidoPositivo(" inserte un numero para ver si es par ");
    checkearPar.VerificarEsPar(userNumeroCheckearPar);
    Console.WriteLine(checkearPar.esPar ? $"El numero {userNumeroCheckearPar} es par." : $"El numero {userNumeroCheckearPar} es impar");


    MultiplosTres encontrarMultiplos = new MultiplosTres();
    int userNumeroCheckearMultiploTres = AyudanteInput.ObtenerEnteroValidoPositivo("inserte un numero distinto hasta el cual ver multiplos de 3 ");
    int[] multiplos = encontrarMultiplos.ObtenerMultiplosTres(userNumeroCheckearPar);
    Console.WriteLine($"Multiplos de 3 hasta el {userNumeroCheckearMultiploTres}");
    foreach (int multiplo in multiplos)
    {
      Console.WriteLine(multiplo);
    }

    EncontrarFactorial encontrarFactorial = new EncontrarFactorial();
    int userFactorialN = AyudanteInput.ObtenerEnteroValidoPositivo(" inserte un numero para encontrar su factorial");
    long factorial = encontrarFactorial.ObtenerFactorial(userFactorialN);
    Console.WriteLine($"El factorial de {userFactorialN} es: {factorial}");

    EncontrarFibonacci encontrarFibonacci = new EncontrarFibonacci();
    int userFibonacciMiembro = AyudanteInput.ObtenerEnteroValidoPositivo(" Inserte hasta que miembro de la serie fibonacci desea imprimir ");
    encontrarFibonacci.ImprimirSerieFibonacci(userFibonacciMiembro);


    /*
     * ojo cuidado
     */

    int userNumeroMagico = AyudanteInput.ObtenerEnteroValidoPositivo("Porfavor inserta un entero positivo");
    Par checkearParMagico = new Par();
    MultiplosTres checkearMultiplosMagico = new MultiplosTres();
    EncontrarFactorial checkearFactorialMagico = new EncontrarFactorial();
    EncontrarFibonacci checkearFibonacciMagico = new EncontrarFibonacci();

    checkearParMagico.VerificarEsPar(userNumeroMagico);
    int[] multiplosMagicos = checkearMultiplosMagico.ObtenerMultiplosTres(userNumeroMagico);
    long factorialMagico = checkearFactorialMagico.ObtenerFactorial(userNumeroMagico);
    checkearFibonacciMagico.ImprimirSerieFibonacci(userNumeroMagico);

    Console.WriteLine(checkearParMagico.esPar ? $"Su numero {userNumeroMagico} es par" : $"Su numero {userNumeroMagico} es impar");
    Console.WriteLine($"Multiplos de 3 hasta su numero magico {userNumeroMagico}");
    foreach (int multiploMagico in multiplosMagicos)
    {
      Console.WriteLine(multiploMagico);
    }
    Console.WriteLine($"El factorial de {userNumeroMagico} es {factorialMagico}");



  }
}
