using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public override string NombreCompleto()
        {
            return $"Sr: {Nombres} {Apellidos}";
        }
    }
}
