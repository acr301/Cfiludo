namespace cinco;


/* Usa el struct “Empleado” del ejercicio anterior. Escribe un programa que filtre los
empleados que viven en una ciudad específica y muestre la información de estos
empleados.
*/

public struct Empleado
{
    public string Nombre;

    // en vez de anidar los structs y hacer una sintaxis engorrosa
    // se construye el struct Empleado con un miembro de tipo Direccion 
    // (del struct Direccion)


    // declaramos el miembro Direccion de tipo Direccion
    public Direccion Direccion;

    public Empleado(string nombre, Direccion direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }
}

public struct Direccion
{
    public string Calle;
    public string Ciudad;
    public int CodigoPostal;

    public Direccion(string calle, string ciudad, int codigoPostal)
    {
        Calle = calle;
        Ciudad = ciudad;
        CodigoPostal = codigoPostal;
    }
}


class Program
{
    static void Main(string[] args)
    {
        /*
          Direccion direccionEmpleado1 = new Direccion("Calle La Calle", "Managua", 69420);
          Empleado empleado1 = new Empleado("Andres", direccionEmpleado1);

          Console.WriteLine($"{empleado1.Nombre}");
          Console.WriteLine($"{empleado1.Direccion.Calle}, {empleado1.Direccion.Ciudad}, {empleado1.Direccion.CodigoPostal}");
        */

        Empleado[] empleados = new Empleado[]
        {
        new Empleado("Cesar", new Direccion("Calle UAM 123", "Managua", 0010)),
        new Empleado("Emilio", new Direccion("Avenida Princial Masaya", "Masaya", 0020)),
        new Empleado("Juan", new Direccion("Camino Siniestra", "Managua", 0019)),
        new Empleado("Tito", new Direccion("Piedra Quemada 5", "Managua", 0013)),
        new Empleado("Francisco", new Direccion("Calle Tuani", "Masaya", 0021)),
        new Empleado("Maria", new Direccion("Calle Bocona", "Granada", 0030)),
        };

        Console.WriteLine(" Inserte ciudad de la cual quiera mostrar empleados ");
        Console.WriteLine(" Opciones: Managua, Masaya, Granada ");

        string ciudadABuscar = Console.ReadLine();
        Console.WriteLine(" ");
        foreach (var empleado in empleados)
        {
            if (ciudadABuscar == empleado.Direccion.Ciudad)
            {
                Console.WriteLine($"{empleado.Nombre}");
                Console.WriteLine($"{empleado.Direccion.Calle}, {empleado.Direccion.Ciudad}, {empleado.Direccion.CodigoPostal}");
            }
        }

    }
}
