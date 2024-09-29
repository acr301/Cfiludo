namespace cuatro;

/* Define un struct llamado “Empleado” que contenga un campo Nombre y otro Direccion,
donde Direccion es otro struc` con campos para Calle, Ciudad, y CódigoPostal. Crea una
instancia de ”Empleado”, asigna valores a todas las propiedades, y muestra la
información completa del empleado en la consola.
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
        Direccion direccionEmpleado1 = new Direccion("Calle La Calle", "Managua", 69420);
        Empleado empleado1 = new Empleado("Andres", direccionEmpleado1);

        Console.WriteLine($"{empleado1.Nombre}");
        Console.WriteLine($"{empleado1.Direccion.Calle}, {empleado1.Direccion.Ciudad}, {empleado1.Direccion.CodigoPostal}");

    }
}
