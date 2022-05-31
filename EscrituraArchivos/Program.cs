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
            Console.Write("Cuantos nombres desea escribir en el archivo: ");
            int j = int.Parse(Console.ReadLine());
            string[] linea = new string[j];
            for (int i = 0; i < linea.Length; i++)
            {
                Console.Write("Indique un nombre: ");
                linea[i] = Console.ReadLine();
            }
            foreach (string line in linea)
            {
                sw.WriteLine(line);
            }
            sw.Close();// Se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo. . .");
            Console.ReadLine();
             
        }
    }
}
