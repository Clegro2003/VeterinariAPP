using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public int Cedula { get; set; }
        public string Telefono { get; set; }

        public Propietario() { }

        public Propietario(string nombre, int cedula, string telefono)
        {
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
        }

        public override string NombreCompleto()
        {
            return $"sr {Nombre} {Apellido}";
        }
    }
}
