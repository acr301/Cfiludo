namespace guiaTrabajo1FlowControl;


public class Par
{
  public int numero;
  public int dos = 2;
  public bool esParONo;

  public bool VerificarEsParoONo(int numero, int dos)
  {

    if (numero mod dos = 0)
    {
      esParONo = true;
    }
    else
    {
      esParONo = false;
    }

    return esParONo;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Par cinco = new Par();
    Par.modular(5, 2);

  }
}
