namespace Ayudantes
{
    public class VerificadorInput
    {
        public int ObtenerEnteroValido(int min, int max)
        {

            int enteroEntrado;
            bool validezEntero = false;
            bool validezEnteroEnRango = false;

            do
            {
                validezEntero = int.TryParse(Console.ReadLine(), out enteroEntrado);

                if (enteroEntrado >= min && enteroEntrado <= max)
                {
                    validezEnteroEnRango = true;
                }

                if (validezEntero && validezEnteroEnRango == true)
                {
                    break;
                }
            }
            while (true); //infinito, hasta que "break" sea ejecutado

            return enteroEntrado;
        }

    }

    // "contrato", toda Accion individual debera proveer una
    // implementacion del metodo Ejecutar al conformarse
    public interface IAccion
    {
        void Ejecutar();
    }
    public class Opcion
    {
        public string Descripcion { get; set; }
        public IAccion Accion { get; set; }

        public Opcion(string descripcion, IAccion accion) => (Descripcion, Accion) = (descripcion, accion);
    }

    public class SelectorMenu
    {

        private List<Opcion> opciones;

        public SelectorMenu(List<Opcion> opciones)
        {
            this.opciones = opciones;
        }
        public void MenuMostrar()
        {

            //inicializamos esto en 0 para que apunte al primer elemento
            //de la lista opciones
            int opcionSeleccionada = 0;

            //instancia del enum ConsoleKey, contiene todas las teclas pulsables
            ConsoleKeyInfo tecla;

            do
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
                            // ejecutamos la accion de dicha opcion
                            opciones[opcionSeleccionada].Accion.Ejecutar();
                            break;
                    }
                }
            } while (true);
        }
    }
}
