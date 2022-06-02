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
        class ListaPromedios
        {
            public string nombre;
            public float prom;
            
            public ListaPromedios(string nombre,float prom)
            {
                this.nombre = nombre;
                this.prom = prom;
            }
            public void Desplegar()
            {
                Console.WriteLine("Datos del alumno \n");
                Console.WriteLine("Nombre del alumno: " + nombre);
                Console.WriteLine("Promedio: {0} ", prom);
            }

        }
        static void Main(string[] args)
        {
            void Limpiar()
            {
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
            }
            StreamWriter sw = new StreamWriter("ListaPromedios.txt", true);
            // Si el archivo no existe lo creara
            // Si ya existe, escribira en el 
            // true es para agregar y no para sobre escribir 
            /*Console.Write("Cuantos nombres desea escribir en el archivo: ");
            int j = int.Parse(Console.ReadLine());
            string[] linea = new string[j];
            int[] edad = new int[j];
            for (int i = 0; i < linea.Length; i++)
            {
                Console.Write("Indique un nombre: ");
                linea[i] = Console.ReadLine();
                    Console.Write("Indique la edad: ");
                    edad[i] = int.Parse(Console.ReadLine());
                sw.WriteLine(linea[i] + "\n" + edad[i]);
            }
            /*foreach (string line in linea)
            {
                sw.WriteLine(line);
                
            }*/
            string nombre;
            float prom;
            Console.WriteLine("Caputura de datos del alumno \n");
            Console.Write("Indique el nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.Write("Indique el promedio del alumno: ");
            prom = float.Parse(Console.ReadLine());

            Limpiar();
            ListaPromedios lista = new ListaPromedios(nombre, prom);
            lista.Desplegar();
            sw.WriteLine("Nombre: " + lista.nombre + "\n" +
                          "Promedio: {0} ", lista.prom); ;

            sw.Close();// Se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo. . .");
            Console.ReadLine();
             
        }
    }
}
