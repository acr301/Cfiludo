namespace ejercicio1Mio;

public class Dados
{
  //miembros que utilizaremos a lo largo de todo el codigo
  const int nTiros = 36000;
  Random rand = new Random();

  //hay 11 numeros entre 2 y 12 inclusivo
  const int nSumasPosibles = 11;

  int[] sumasPosibles = {
    2, // 0 
    3,
    4,
    5,
    6,
    7, // 5 media aritmetica de indices
    8,
    9,
    10,
    11,
    12, // 10 
  };  // sumaPosible = indice + 2;

  int[] sumasPosiblesApariciones = new int[nSumasPosibles];

  public int SumaDados()
  {
    //genera y asigna nums del 1 al 6 inclusivo por eso el 7
    int dado1 = rand.Next(1, 7);
    int dado2 = rand.Next(1, 7);

    //suma los dos numeros generados
    //sumas posibles son de 2 a 12
    int sumaDados = dado1 + dado2;
    return sumaDados;
  }


  public int[] Tirar()
  {
    for (int i = 0; i < nTiros; i++)
    {
      int sumaDadosTirar = SumaDados();

      // Incrementamos directamente la aparición de la suma en el índice correspondiente
      sumasPosiblesApariciones[sumaDadosTirar - 2]++;
    }
    return sumasPosiblesApariciones;
  }

  public void ImprimirTabular()
  {
    int[] aparicionesResultantes = Tirar();
    Console.Write("Apariciones resultantes: ");
    foreach (int aparicionResultante in aparicionesResultantes)
    {
      int nAparicionPosible = Array.IndexOf(aparicionesResultantes, aparicionResultante);
      Console.Write($"\n|{nAparicionPosible + 2}|  |{aparicionResultante}|");
    }
  }
}


class Program
{
  static void Main(string[] args)
  {
    Dados tiraje = new Dados();
    tiraje.ImprimirTabular();
  }
}
