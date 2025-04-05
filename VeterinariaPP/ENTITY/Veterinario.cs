using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Veterinario : Persona
    {
        public override string NombreCompleto()
        {
            return $"Dr: {Nombres} {Apellidos}";
        }
    }
}
