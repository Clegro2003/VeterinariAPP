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
    public class RazaService : IService<Raza>
    {
        private readonly RazaRepository _repo;

        public RazaService()
        {
            _repo = new RazaRepository(Archivos.ARC_RAZA);
        }

        public string Guardar(Raza entidad)
        {
            try
            {
                if (entidad == null)
                {
                    throw new NullReferenceException("la raza no puede ser nula");
                }
                return _repo.Guardar(entidad);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Raza> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            var lista = _repo.Consultar();
            var eliminado = lista.RemoveAll(r => r.IdRaza == id) > 0;

            if (eliminado)
            {
                File.WriteAllLines(_repo._filepath, lista.Select(r => r.ToString()));
            }

            return eliminado;
        }
    }
}
