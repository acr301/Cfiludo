namespace Ayudantes
{

    public class ResultadoValidacion
    {

        //simple propiedad de criterio de si es valido o no, modificable y legible
        public bool esValido { get; set; }

        //declaramos e instanciamos los mensajes de error 
        //conveniente para darle una idea al usuario de lo que hizo mal
        public List<string> MensajesError { get; set; } = new List<string>();

        //construimos la propiedad de validez, asignandole por
        //defecto true, asi en la logica tenemos el "happy path"
        //con negaciones de este
        public ResultadoValidacion()
        {
            esValido = true;
        }
    }

    //en el programa Main, iniciaremos asignando a una variable el valor que retorne
    // llamar al metodo CrearValidador con el tipo deseado entre < >,
    // que crea un Validador<tipoDeseado>, a traves del que llamamos al metodo
    // AgregarRegla, donde AgregarRegla(dato => AyudanteValidacion.ReglaEspecifica(input "nombreCampo"));
    //
    //  asignamos a una variable el valor a validar 
    //
    // campoValidacionResultado = la variable que creamos de primero.Validar(variable del dato)
    public static class AyudanteValidacion
    {

        // metodo para poder crear un validador DE/PARA cualquier tipo
        public static Validador<T> CrearValidador<T>()
        {
            return new Validador<T>();
        }

        // ----------- AQUI LAS REGLAS ESPECIFICAS APLICABLES COMO METODOS ESTATICOS -----------

        public static ResultadoValidacion ValidarRequerido(string input, string nombreCampo)
        {
            ResultadoValidacion resultado = new ResultadoValidacion();
            if (string.IsNullOrWhiteSpace(input))
            {
                resultado.esValido = false;
                resultado.MensajesError.Add($"{nombreCampo} es obligatorio ");
            }
            return resultado;
        }

        public static ResultadoValidacion ValidarRequeridoDoblePositivo(double? input, string nombreCampo)
        {
            ResultadoValidacion resultado = new ResultadoValidacion();
            if (input == null || input <= 0)
            {
                resultado.esValido = false;
                resultado.MensajesError.Add($"{nombreCampo} debe ser positivo");
            }
            return resultado;
        }
    }


    //clase de validador generico
    public class Validador<T>
    {
        //el delegado Func<T,TResultado> encapsula el metodo ResultadoValidacion
        private readonly List<Func<T, ResultadoValidacion>> _reglas = new List<Func<T, ResultadoValidacion>>();


        //constructor 
        public Validador<T> AgregarRegla(Func<T, ResultadoValidacion> regla)
        {
            _reglas.Add(regla);
            return this;
        }


        /// ESTO ES LO MAS IMPORTANTE, EL METODO QUE RETORNA
        /// LA VALIDACION DE CUALQUIER TIPO
        public ResultadoValidacion Validacion(T valor)
        {
            ResultadoValidacion resultado = new ResultadoValidacion();

            foreach (var regla in _reglas)
            {
                var resultadoRegla = regla.Invoke(valor);
                if (!resultadoRegla.esValido)
                {
                    resultado.esValido = false;
                    resultado.MensajesError.AddRange(resultadoRegla.MensajesError);
                }
            }
            return resultado;
        }
    }




    //----------------------------MENU, OPCIONES, ACCIONES -----------------------


    // "contrato", toda Accion individual debera proveer una
    // implementacion del metodo Ejecutar al conformarse
    public interface IAccion
    {
        void Ejecutar();
    }

    public class AccionSalir : IAccion
    {
        public void Ejecutar()
        {
            Console.WriteLine(" Saliendo del programa... ");
        }
    }

    //unidad elemental con la que interactua el usuario
    public class Opcion
    {
        public string Descripcion { get; set; }
        public IAccion Accion { get; set; }

        public Opcion(string descripcion, IAccion accion) => (Descripcion, Accion) = (descripcion, accion);
    }

    public class SelectorMenu
    {

        private List<Opcion> opciones;
        // se debera instanciar un SelectorMenu, bajo el que se instancien
        // una o mas opciones con su respectiva Descripcion y Accion

        public SelectorMenu(List<Opcion> opciones)
        {
            this.opciones = opciones;
        }

        public void MenuMostrar()
        {

            //inicializamos esto en 0 para que apunte al primer elemento
            //de la lista opciones
            int opcionSeleccionada = 0;

            // por defecto true, haremos false 
            // dependiendo de tecla del usuario
            bool continuarMostrando = true;

            //instancia del enum ConsoleKey, contiene todas las teclas pulsables
            ConsoleKeyInfo tecla;

            while (continuarMostrando)
            {
                Console.Clear();

                //por cada una de las opciones
                for (int i = 0; i < opciones.Count; i++)
                {
                    //se dara formato visual a la que este seleccionada
                    if (i == opcionSeleccionada)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i].Descripcion}");
                        Console.ResetColor();
                    }
                    else //la que no este seleccionada
                    {
                        Console.WriteLine($"  {opciones[i].Descripcion}");
                    }


                    //overload booleano al metodo que pide leer, 
                    //pasa esa tecla leida a tecla invocando el metodo .Key
                    tecla = Console.ReadKey(true);

                    switch (tecla.Key)
                    {
                        case ConsoleKey.UpArrow:
                            opcionSeleccionada--;

                            // si se pulsa hacia arriba siendo el valor 0, es decir,
                            // se vuelve -1, entonces le asignamos el ultimo valor,
                            // para que "vaya hasta abajo"
                            if (opcionSeleccionada < 0)
                                opcionSeleccionada = opciones.Count - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            opcionSeleccionada++;

                            // manda al principio
                            if (opcionSeleccionada >= opciones.Count)
                                opcionSeleccionada = 0;
                            break;


                        case ConsoleKey.Enter:
                            Console.Clear();
                            // ejecutamos la accion de dicha opcion
                            opciones[opcionSeleccionada].Accion.Ejecutar();

                            if (opciones[opcionSeleccionada].Accion is AccionSalir)
                            {
                                continuarMostrando = false;
                            }
                            break;

                        case ConsoleKey.Escape:
                            return;
                    }
                }
            }
        }
    }
}
