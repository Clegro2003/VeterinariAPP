using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ConsultaVeterinaria
    {
        public DateTime Fecha { get; set; }
        public Veterinario Veterinario { get; set; }
        public Mascota Mascota { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
    }
}
