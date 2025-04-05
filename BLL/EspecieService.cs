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
    public class EspecieService : IService<Especie>
    {
        private readonly EspecieRepository _repo;

        public EspecieService()
        {
            _repo = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public string Guardar(Especie entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("la especie no puede ser nula");
                }
                return _repo.Guardar(entity);
            }
            catch
            {
                return null;
            }
        }

        public List<Especie> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            var lista = _repo.Consultar();
            var eliminado = lista.RemoveAll(e => e.IdEspecie == id) > 0;

            if (eliminado)
            {
                File.WriteAllLines(_repo._filepath, lista.Select(e => e.ToString()));
            }

            return eliminado;
        }
    }
    
}
