namespace sesion260824;
using System;
using System.Runtime.InteropServices;


/* sizeof(tipo) no es seguro, porque usa memoria unmanaged
 * Marshal.SizeOf(typeof(tipo)) hace algo llamado Type Marshalling
 * 
 * que permite transformar entre codigo managed y codigo nativo
 *https://learn.microsoft.com/en-us/dotnet/standard/native-interop/type-marshalling
*/
public class Program
{
  static void Main(string[] args)
  {

    Type[] tipos = {
          typeof(byte),
          typeof(sbyte),
          typeof(short),
          typeof(ushort),
          typeof(int),
          typeof(uint),
          typeof(long),
          typeof(float),
          typeof(double),
          typeof(char),
          typeof(bool)
        };

    foreach (var tipo in tipos)
    {
      Console.WriteLine($"Tamaño de {tipo.Name}: {Marshal.SizeOf(tipo)} bytes");
      Console.WriteLine($"Tamaño total de {tipo.Name}: {Math.Pow(2, 8 * (Marshal.SizeOf(tipo)))}");
    }



  }
}
