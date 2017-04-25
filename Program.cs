using institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTION DE INSTITUCION");

            Persona[] lista = new Persona[3];
            lista[0] = new Alumno("Wilfredo", "Bardales")
            {
                Id = 1,
                Edad = 20,
                Telefono = 1166861931,
                Email = "willybc06@gmail.com"
            };


            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = "Juan",
                Apellido = "Ruiz",
                Edad = 34,
                Teléfono = 55555555,
                Catedra = "Programacion"
            };

            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = "William",
                Apellido = "Torvalds",
                Edad = 25,
                Teléfono = 911,
                Catedra = "Algebra"
            };


            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());

                IEnteInstituto ente = p;

                ente.ConstruirLlaveSecreta("Hola");
            }



            Console.ReadLine();

        }
    }
}
