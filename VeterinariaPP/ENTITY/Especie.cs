using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Especie: NamedEntity
    {
        public Especie()
        {
                
        }
        public Especie(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        //public string Nombre { get; set; }
        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }
    }
}
