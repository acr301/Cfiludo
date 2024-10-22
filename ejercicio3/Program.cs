/*
 Desarrollar un programa que se comporte como un diccionario Inglés-Español; esto es, solicitará
una palabra en inglés y escribirá la correspondiente palabra en español. Para hacer más sencillo
el ejercicio, el número de parejas de palabras estará limitado a 5. Por ejemplo, suponer que
introducimos las siguientes parejas de palabras:
book libro
green verde
mouse ratón

Una vez finalizada la introducción de las listas de palabras, pasamos al modo traducción, de
forma que si introducimos green, la respuesta ha de ser verde. Si la palabra no se encuentra, se
emitirá un mensaje que lo indique.
El programa constará de dos métodos, aparte de Main():
1. crearDiccionario(). Este método creará el diccionario.
2. traducir(). Este método realizará la labor de traducción.
 
*/
namespace DiccionarioT
{
    internal class DiccionarioT
    {
        public static void Main(string[] agrs)
        {
            List<Tuple<string, string>> diccionario = crearDiccionario();
            traducir(diccionario);
        }

        public static List<Tuple<string, string>> crearDiccionario()

        {
            List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();
            //pedimos las pares de palabras
            for (int i = 0; i < 5; i++)
            {
                //variables independientes
                Console.WriteLine($"Introduzca la palabra {i + 1} en ingles: ");
                string palabra1 = Console.ReadLine();
                Console.WriteLine($"Introduzca la palabra {i + 1} en espanol: ");
                string palabra2 = Console.ReadLine();


                diccionario.Add(new Tuple<string, string>(palabra1, palabra2));

            }
            return diccionario;//se lo retornamos a diccionario

        }

        public static void traducir(List<Tuple<string, string>> diccionario)
        {
            Console.Write("Introduzca la palabra a traducir: ");
            string palcomp = Console.ReadLine();
            bool encontrado = false;

            foreach (var duo in diccionario) // POR CADA PAR 
            {
                if (duo.Item1.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"La traduccion de la palabra {palcomp} es: {duo.Item2}. ");
                    encontrado = true;
                    break;
                }
                else if (duo.Item2.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"La traduccion de la palabra {palcomp} es: {duo.Item1}. ");
                    encontrado = true;
                }
            }

            if (!encontrado)//si no lo encontro
            {
                Console.Write($"La palabra {palcomp} no fue encontrada. ");
            }

        }

    }

}


