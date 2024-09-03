using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTextoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string line;

            

            try
            {
                string fileName = "D:\\Nota.txt";
                
                StreamWriter writer = File.AppendText(fileName);
                
                Console.WriteLine("Ingrese nombre estudiante: ");
                var nombre = Console.ReadLine();
                //writer.WriteLine(nombre);
                

                Console.WriteLine("Ingrese identifición del estudiante: ");
                var id = Console.ReadLine();
                //writer.WriteLine(id);
                

                Console.WriteLine("Ingrese la asignatura: ");
                var asignatura = Console.ReadLine();
                //writer.WriteLine(asignatura);
                

                Console.WriteLine("Ingrese nota 1: ");
                var nota1 = float.Parse(Console.ReadLine());
                //writer.WriteLine(nota1);
                

                Console.WriteLine("Ingrese nota 2: ");
                var nota2 = float.Parse(Console.ReadLine());
                //writer.WriteLine(nota2);
                

                Console.WriteLine("Ingrese nota 3: ");
                var nota3 = float.Parse(Console.ReadLine());
                //writer.WriteLine(nota3);
                

                var resultado = (nota1 + nota2 + nota3) / 3;

                string definitiva;
                if (resultado >= 3.0)
                {
                    definitiva = "APROBO";
                }
                else 
                {
                    definitiva = "NO APROBO";
                }

                writer.WriteLine($".Nombre alumno: {nombre} \n.Id: {id} \n.Asignatura: {asignatura}  \n.Definitiva: : {resultado} \n.Estado: {definitiva}");
              

                Console.WriteLine($".Nombre alumno: {nombre} \n.Id: {id} \n.Asignatura: {asignatura}  \n.Definitiva: : {resultado} \n.Estado: {definitiva}");

                writer.Close();

                StreamReader sr = new StreamReader("D:\\Nota.txt");
             
                line = sr.ReadLine();
                

                while (line != null)
                {
                    
                    Console.WriteLine(line);
                    
                    line = sr.ReadLine();
                }
                
                sr.Close();
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error");
                
                Console.ReadKey();
            }


        }
    }
}

            
    