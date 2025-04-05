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
    public class MascotaService : IService<Mascota>
    {
        private readonly MascotaRepository _repo;
        private readonly RazaRepository _Razarepo;
        private readonly PropietarioRepository _Propietariorepo;

        public MascotaService()
        {
            _repo = new MascotaRepository(Archivos.ARC_MASCOTA, _Propietariorepo, _Razarepo);
        }

        public string Guardar(Mascota entidad)
        {
            try
            {
                if (entidad == null)
                {
                    throw new NullReferenceException("la mascota no puede ser nula");
                }
                    return _repo.Guardar(entidad);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Mascota> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            var lista = _repo.Consultar();
            var eliminado = lista.RemoveAll(m => m.IdMascota == id) > 0;

            if (eliminado)
            {
                File.WriteAllLines(_repo._filepath, lista.Select(m => m.ToString()));
            }

            return eliminado;
        }
    }
}
