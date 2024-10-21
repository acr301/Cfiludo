using System;
using System.Collections.Generic;//permite el uso de las colecciones genericas <List>, entre otras
using System.Linq;//permite realizar consultas a colecciones de datos(lista, arrays) de manera concisa
using System.Text;//proporciona clases para manipulacion de textos, como String Builder para construir o modificar cadenas de texto
using System.Threading.Tasks;//usa el patron Task, util para operaciones como la lectura de archivos o llamadas de bases de datos sin detener el hilo principal
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
        //solo hacemos el llamado a los dos metodos
        {
            List<Tuple<string, string>> diccionario = crearDiccionario();
            traducir(diccionario);
        }

        public static List<Tuple<string, string>> crearDiccionario()//ponemos el tipodo, metodo
                                                                    //crear estructura de tipo string, string
        {
            List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();//()hacemos llamado al contructor, inicializa la estructura
            //pedimos las pares de palabras
            for (int i = 0; i < 5; i++)
            {
                //variables independientes
                Console.WriteLine($"Introduzca la palabra {i + 1} en ingles: ");//interpolar strings
                string palabra1 = Console.ReadLine();
                Console.WriteLine($"Introduzca la palabra {i + 1} en espanol: ");
                string palabra2 = Console.ReadLine();
                //por cada par de palabra la ingresamos al objeto y anadimos a la estructura
                //agregamos a la lista
                diccionario.Add(new Tuple<string, string>(palabra1, palabra2));//recuperacion de las palabras e incorporacion al diccionario

            }
            return diccionario;//se lo retornamos a diccionario

        }

        //seria de tipo void por solo vamos a pasar no a retornar
        public static void traducir(List<Tuple<string, string>> diccionario)
        {
            Console.Write("Introduzca la palabra a traducir: ");
            string palcomp = Console.ReadLine();//palabra a traducir
            bool encontrado = false;

            foreach (var duo in diccionario)//todos los elemntos estan en duo
            {
                if (duo.Item1.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
                //de la tupla el primer elemento y se compara con el primer elemento de la lista
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


