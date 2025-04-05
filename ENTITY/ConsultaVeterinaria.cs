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
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public Mascota Mascota { get; set; }

        public ConsultaVeterinaria()
        {
            
        }

        public ConsultaVeterinaria(DateTime fecha, Veterinario veterinario, string diagnostico, string tratamiento, Mascota mascota)
        {
            Fecha = fecha;
            Veterinario = veterinario;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Mascota = mascota;
        }

        public override string ToString()
        {
            return $"{Fecha:yyyy-MM-dd};{Veterinario};{Diagnostico};{Tratamiento};{Mascota.Nombre}";
        }
    }
}
