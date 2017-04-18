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

            var alumno1 = new Alumno("Willy", "Bardales" )
            {
              Id=1,
              Edad=20,
              Teléfono=1166861931,
              Email="willybc06@gmail.com"
            };

            var profesor1 = new Profesor()
            {
                Id = 1,
                Nombre = "Juan",
                Apellido = "Ruiz",
                Edad = 34,
                Teléfono = 55555555,
                Catedra="Programacion"
            };


            Console.WriteLine(Persona.ContadorPersonas);

            Console.ReadLine();
            
        }
    }
}
