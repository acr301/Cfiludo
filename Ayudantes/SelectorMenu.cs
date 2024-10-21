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
        public int Menu(List<string> opciones)
        {
            int indiceInicial = 0;

            return indiceInicial;
        }
    }
}
