using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
        public class Raza
        {
            public string Nombre { get; set; }
            public Especie Especie { get; set; }
            public int IdRaza { get; set; }

        public Raza()
        {
            
        }

        public Raza(string nombre, Especie especie, int idRaza)
            {
                Nombre = nombre;
                Especie = especie;
                IdRaza = idRaza;
            }

            public override string ToString()
            {
                return $"{Nombre} ({Especie.Nombre})";
            }
        }
    }

