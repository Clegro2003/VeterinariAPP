using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropietarioRepository : FileRepository<Propietario>
    {
        public PropietarioRepository(string filePath) : base(filePath) { }

        public override List<Propietario> Consultar()
        {
            var lista = new List<Propietario>();
            foreach (var linea in File.ReadAllLines(_filepath))
            {
                lista.Add(Map(linea));
            }
            return lista;
        }

        public override Propietario Map(string dato)
        {
            var partes = dato.Split(';');
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(partes[0]);
            propietario.Nombre = partes[1];
            propietario.Telefono = partes[2];
            return propietario;
        }
    }
}