using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Expresión regular para validar una URL simple
        string patron = @"^(https?://)?([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,6})(:[0-9]+)?(/[\w.-]*)*(\?\S*)?$";

        string url = "https://www.ejemplo.com";
        
        if (Regex.IsMatch(url, patron))
        {
            Console.WriteLine("La URL es válida.");
        }
        else
        {
            Console.WriteLine("La URL no es válida.");
        }
    }
}
//Este código utiliza la clase Regex del espacio de nombres System.Text.RegularExpressions 
//para realizar una coincidencia de patrones con la URL proporcionada. 
//La expresión regular patron en este ejemplo valida una URL que 
//comienza con "http://" o "https://", seguido de un dominio, una posible port, y una posible ruta.
 
//Puedes ajustar esta expresión regular según tus necesidades específicas de validación de URL.





