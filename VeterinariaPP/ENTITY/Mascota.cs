using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota: NamedEntity
    {
        
        public Propietario Propietario { get; set; }
        public int Edad { get; set; }
        public Raza Raza { get; set; }
    }
}
