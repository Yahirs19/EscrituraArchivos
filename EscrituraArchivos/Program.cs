using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // Si el archivo no existe lo creara
            // Si ya existe, escribira en el 
            // true es para agregar y no para sobre escribir 
            string[] linea =
            {
                "Esta es la informacion de la primera linea",
                "Esta es la segunda linea ",
                "Fin del texto"
            };
            foreach (string line in linea)
            {
                sw.WriteLine(line);
            }
            sw.Close();// Se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo. . .");
            Console.ReadLine();
             for (int i = 0; i < linea.Length; i++) 
             {
            Console.WriteLine(linea[i]);
           }
        }
    }
}
