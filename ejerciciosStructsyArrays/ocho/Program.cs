namespace ocho;

/* Crea un struct llamado “CuentaBancaria” con campos para NumeroDeCuenta,
NombreTitular, y Saldo. Agrega un constructor que permita inicializar todos los campos.
Crea un arreglo de “CuentaBancaria”, inicialízalo usando el constructor, y muestra la
información de cada cuenta.
*/

public struct CuentaBancaria
{
    public int NumeroDeCuenta;
    public string NombreTitular;
    public double Saldo;

    public CuentaBancaria(int numeroDeCuenta, string nombreTitular, double saldo)
    {
        NumeroDeCuenta = numeroDeCuenta;
        NombreTitular = nombreTitular;
        Saldo = saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria[] cuentas = new CuentaBancaria[]
        {
        new CuentaBancaria(000001, "Andres", 45389.20),
        new CuentaBancaria(000002, "Fatima", 1345812.85),
        new CuentaBancaria(000003, "Cesar", 99999999.99),
        };

        foreach (var cuenta in cuentas)
        {
            Console.WriteLine($"numero de cuenta {cuenta.NumeroDeCuenta}, titular {cuenta.NombreTitular}, saldo {cuenta.Saldo}");
        }
    }
}
