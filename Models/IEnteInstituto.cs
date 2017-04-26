using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    public interface IEnteInstituto
    {
        string CodigoInterno { get; set; }

        string ConstruirLlaveSecreta(string nombreEnte);
    }
}
