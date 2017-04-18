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

            var alumno1 = new Alumno()
            {
              Id=1,
              Nombre="Willy",
              Apellido="Bardales",
              Edad=20,
              Teléfono=1166861931,
              Email="willybc06@gmail.com"
            };

            var persona1 = new Persona()
            {
                Id = 1,
                Nombre = "Juan"
                Apellido = "Perez",
                Edad = 25,
                Teléfono = 55555555,
                
            }


            Console.ReadLine();
            
        }
    }
}
