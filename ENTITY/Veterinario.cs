using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Veterinario : Persona
    {
        public string Especialidad { get; set; }
        private static List<Veterinario> veterinarios = new List<Veterinario>();

        public Veterinario() 
        {
            
        }

        public Veterinario(string nombre, int cedula, string especialidad)
        {
            Nombre = nombre;
            Cedula = cedula;
            Especialidad = especialidad;
        }

        public override string NombreCompleto()
        {
            return $"{Nombre}; {Apellido}";
        }
    }
}
