using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Alumno: Persona
    {
        public string Email { get; set; }

        private int Inasistencias { get; set; }
        
        public string ListaInasistencias()
        {
            return Inasistencias.ToString();
        }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
