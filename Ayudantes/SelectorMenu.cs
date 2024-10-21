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

    public class SelectorMenu
    {
        public int Menu(List<string> options)
        {
            return 0;
        }
    }
}
