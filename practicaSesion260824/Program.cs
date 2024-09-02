namespace practicaSesion260824;
using System;


/*como parte del aprendizaje que me llevo a poder entender y escribir este codigo,
 la conversion de float a double implicita (sin casting), es posibleal
 al reves no, porque puede llevar a perdida de precision
 ya que double > float
 */

public class Producto
{

  /*declaracion como propiedades automaticas
   * con el atajo Propiedad { get; set; }
  de manera que los campos esten privados implicitos
  el hacer esto permite mas facil hacer los datos
  del producto de solo escritura o solo lectura
  */

  //pongo ya algo en el campo de los strings para que no me pida que
  //especifique que es Nullable
  private string _nombre = "";
  private string outputDisponibilidad = "";
  private string _mensajePromo = "";
  private string _promocion = "";
  public string Nombre
  {
    get => _nombre;
    set { _nombre = value; }
  }

  public int Codigo
  { get; set; }

  public float Precio
  { get; set; }

  public bool Disponibilidad
  { get; set; }

  public char Categoria
  { get; set; }

  public double Descuento
  { get; set; }

  public string Promocion
  {
    get => _promocion;
    set { _promocion = value; }
  }

  public float PrecioConDescuento
  { get; set; }

  public string MensajePromo
  {
    get => _mensajePromo;
    set { _mensajePromo = value; }
  }

  //metodo descuentador que incluye el feature plus de concatenar la Promocion
  public string Descuentador(char Categoria, float Precio, double Descuento)
  {

    double descuentoOperador = Descuento / 100;

    if ((Categoria == 'A') && (Precio > 100))
    {
      PrecioConDescuento = (float)(Precio - ((Precio * (descuentoOperador + 0.1))));
      MensajePromo = "Promoción aplicada, categoría A y precio mayor a 100, aplica 10% de descuento adicional";
    }
    else if ((Categoria == 'B') && (Precio <= 50))
    {
      PrecioConDescuento = (float)(Precio - ((Precio * (descuentoOperador + 0.05))));
      MensajePromo = "Promoción aplicada, categoría B y su precio es menor o igual a 50, aplica 5% de descuento adicional";
    }
    else
    {
      MensajePromo = "No aplican promociones para su producto";
      PrecioConDescuento = Precio;
    }

    Promocion = PrecioConDescuento.ToString() + " " + MensajePromo;
    return Promocion;
  }

  /*                  COMENTARIOS SOBRE WARNINGS AL HACER dotnet build , e info sobre nulls y validacion de input
   * ------------------------------------------------------------------------------------------------
   * todo este metodo lanza 
   * warnings de possible null reference
   * y eso puede ser un error
   * NullReferenceException
   * de compilador A value type cannot be null
   * es decir, puede que las Propiedades como referencias no se refieran a ningun objeto
   * porque en efecto, puede que el usuario no entre nada
   *
   *
   * lo bueno es que una string vacia no es lo mismo que una string nula
   * tipo? Propiedad = null o cualquier input del usuario
   * en vez de usar un si, tal y tal null, hacer tal, se puede hacer
   * nil coalescing
   * Propiedad ?? EvaluarSiPropiedadNull
   *
   *
   * lo mejor seria una validacion para aprender de los tipos 
   * para ver si el user inputea una string
   * compatible con un tipocorrecto
   *
   *tipocorrecto valorcorrecto;
   *si (TipoCorrecto.TryParse(Console.ReadLine(), out valorcorrecto)
      correr lo que si
   de lo contrario
      decirle al usuario que su input es invalido
  ----------------------------------------------------------------------------------------------------
   */
  public void SolicitarProducto()
  {
    Console.WriteLine("Producto");

    Console.Write("Inserte nombre: ");
    Nombre = Console.ReadLine();

    Console.Write("Inserte código: ");
    Codigo = int.Parse(Console.ReadLine());

    Console.Write("Inserte precio: ");
    Precio = float.Parse(Console.ReadLine());

    Console.Write("Inserte disponibilidad: ");
    Disponibilidad = bool.Parse(Console.ReadLine());

    Console.Write("Inserte categoría: ");
    Categoria = char.Parse(Console.ReadLine());

    Console.Write("Inserte descuento: ");
    Descuento = double.Parse(Console.ReadLine());
  }

  public string[] SolicitarProductoArreglo()
  {
    if (Disponibilidad == true)
    {
      outputDisponibilidad = "Se encuentra disponible";
    }
    else
    {
      outputDisponibilidad = "Se encuentra indisponible";
    }

    string[] productoRespuestasArreglo = new string[]
    {
      "Nombre: " + Nombre,
      "Código: " + Codigo.ToString(),
      "Precio: " + Precio.ToString() + " córdobas oro",
      outputDisponibilidad,
      "Categoría: " + Categoria.ToString(),
      "Descuento: " + Descuento.ToString() + "%",
    };

    return productoRespuestasArreglo;
  }

}

class Program
{
  static void Main(string[] args)
  {
    Producto producto1 = new Producto();
    producto1.SolicitarProducto();
    string[] productoRespuestasArreglo = producto1.SolicitarProductoArreglo();
    Console.WriteLine("");


    //de haber usado un constructor, es decir, que los productos TUVIERAN QUE SI O SI, tener todo esto
    // Producto producto1 = new Producto("chicle",5050,10,true,'A',20);

    Console.WriteLine("Información de producto: ");

    foreach (var respuesta in productoRespuestasArreglo)
    {
      Console.WriteLine(respuesta);
    }



    Console.WriteLine(" ");
    Console.Write("El precio final es: ");
    Console.WriteLine(" ");
    Console.Write(producto1.Descuentador(producto1.Categoria, producto1.Precio, producto1.Descuento));
  }
}











