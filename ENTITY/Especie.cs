using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Especie
    {
       
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public int IdEspecie { get; set; }

        public Especie(string nombre, string descripcion, int idEspecie)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            IdEspecie = idEspecie;
        }

        public Especie()
        {
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
