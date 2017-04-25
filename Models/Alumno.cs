using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Alumno : Persona
    {
        public string Email { get; set; }

        private int Inasistencias { get; set; }
        public string NickName { get; set; }
        public int Telefono { get; set; }

        public string ListaInasistencias()
        {
            return Inasistencias.ToString();
        }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {Email}, {Telefono}";
        }

        public override string NombreCompleto
        {
            get
            {
                return base.NombreCompleto.ToUpper();
            }
        }

    }
}
