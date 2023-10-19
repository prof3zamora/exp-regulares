using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string cadena = "SI( texto1 == texto2 ) { imprime('es valido'); }";

        // Patrón de expresión regular para buscar la cadena 'SI( texto1 == texto2 ) { imprime('es valido'); }'
        string patron = @"SI\(\s*([^=]+)\s*==\s*([^=]+)\s*\)\s*\{\s*imprime\('es valido'\);\s*\}";

        // Crear un objeto Regex con el patrón
        Regex regex = new Regex(patron);

        // Comprobar si la cadena cumple con la expresión regular
        if (regex.IsMatch(cadena))
        {
            Console.WriteLine("La cadena sigue el patrón deseado.");
        }
        else
        {
            Console.WriteLine("La cadena no sigue el patrón deseado.");
        }
    }
}

    //  SI\(: Coincide con la cadena 'SI(' literal.
    //  \s*([^=]+)\s*==\s*([^=]+)\s*: Captura los valores texto1 y texto2 en el contexto de una comparación.
    //  [^=] :Cualquier caracter a excepción de '=' 
    //  \)\s*\{\s*imprime\('es valido'\);\s*\}: Coincide con la cadena '){ imprime('es valido'); }' literal con espacios opcionales.
