using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public Raza Raza { get; set; }
        public int Edad { get; set; }
        public Propietario Propietario { get; set; }
        public int IdMascota { get; set; }
        public Mascota(string nombre, Raza raza, int edad, Propietario propietario, int idMascota)
        {
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            Propietario = propietario;
            IdMascota = idMascota;
        }

        public Mascota()
        {
        }

        public override string ToString()
        {
            return $"{Nombre};{Raza.Nombre};{Raza.Especie.Nombre};{Edad};{Propietario.Cedula}";
        }
    }
}

