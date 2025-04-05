using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PropietarioService : IService<Propietario>
    {
        private readonly PropietarioRepository _repo;

        public PropietarioService()
        {
            _repo = new PropietarioRepository(Archivos.ARC_PROPIETARIO);
        }

        public string Guardar(Propietario entidad)
        {
            try
            {
                if (entidad == null)
                {
                    throw new NullReferenceException("El propietario no puede ser nulo");
                }
                return _repo.Guardar(entidad);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Propietario> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            var lista = _repo.Consultar();
            var eliminado = lista.RemoveAll(p => p.Cedula == id) > 0;

            if (eliminado)
            {
                File.WriteAllLines(_repo._filepath, lista.Select(p => p.ToString()));
            }

            return eliminado;
        }
    }
}
