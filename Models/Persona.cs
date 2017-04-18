using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public int Teléfono { get; set; }
        public string NombreCompleto
        {
            get {
                return Nombre + " " + Apellido;
                }
        }



    }

  
}
