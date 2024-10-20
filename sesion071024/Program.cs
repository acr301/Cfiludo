namespace sesion071024;

/*
Escribe un programa que convierta entre diferentes unidades
de medida. Utiliza un menú para seleccionar las conversiones
disponibles y pide al usuario que ingrese los valores
correspondientes.
Menú de opciones:
1. Convertir metros a kilómetros
2. Convertir kilogramos a gramos
3. Convertir litros a mililitros
4. Convertir Celsius a Fahrenheit
5. Convertir horas a minutos
6. Salir
El programa debe solicitar el valor a convertir y luego realizar la
conversión elegida, mostrando el resultado al usuario.
*/



public class Menu()
{

    public void ImprimirMenu()
    {
        string TextoMenu = @"
      --MENU DE CONVERSIONES--

      1. Convertir de metros a kilómetros
      2. Convertir kilogramos a gramos
      3. Convertir litos a mililitros
      4. Convertir Celsius a Fahrenheit
      5. Convertir horas a minutos
      6. Salir
      ";

        Console.WriteLine(TextoMenu);
    }

}

public class Validacion
{

    // se podria hacer con una interfaz que obviara el tipo a validar con tal que sea 
    // consistente el metodo TryParse


    public static int obtenerEnteroValido()
    {
        int number;
        while (true)
        {
            string input = obtenerInputUser();
            if (esEnteroValido(input, out number) && estaEnRango(number))
            {
                return number;
            }
            MensajeError();
        }
    }

    public static double obtenerDoubleValido()
    {
        double number;
        while (true)
        {
            string input = obtenerInputUser();
            if (esDoubleValido(input, out number) && doubleEstaEnRango(number))
            {
                return number;
            }
            MensajeError();
        }
    }

    static string obtenerInputUser()
    {
        return Console.ReadLine();
    }


    // funciones que retornan los booleanos individuales para la logica 

    static bool esEnteroValido(string input, out int number)
    {
        return int.TryParse(input, out number);
    }

    static bool esDoubleValido(string input, out double number)
    {
        return double.TryParse(input, out number);
    }

    static bool estaEnRango(int number)
    {
        //return number >= min && number <= max;
        //si se modularizara para pasarle un rango escogible
        return number >= 1 && number <= 6;
    }

    static bool doubleEstaEnRango(double number)
    {
        return number > 0;
    }

    static void MensajeError()
    {
        Console.WriteLine("Entrada invalida");
    }
}
public class Conversiones()
{

    public double longitud(double m)
    {
        return m / 1000;
    }

    public double masa(double kg)
    {
        return kg * 1000;
    }

    public double volumen(double l)
    {
        return l * 1000;
    }

    public double temperatura(double c)
    {
        return (c * (9 / 5) + 32);
    }

    public double tiempo(double hr)
    {
        return hr * 60;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        menu1.ImprimirMenu();

        int opcionValidada = Validacion.obtenerEnteroValido();
        int valorValidado = Validacion.obtenerDoubleValido();
    }
}
