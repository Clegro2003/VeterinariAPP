using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public Propietario() { }

        public Propietario(string nombre, int cedula, int telefono)
        {
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Cedula}; {Nombre}; {Apellido}; {Telefono}";
        }
    }
}
