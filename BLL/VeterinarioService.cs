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
    public class VeterinarioService : IService<Veterinario>
    {
        private readonly VeterinarioRepository _repo;

        public VeterinarioService()
        {
            _repo = new VeterinarioRepository(Archivos.ARC_VETERINARIO);
        }

        public string Guardar(Veterinario entidad)
        {
            try
            {
                if (entidad == null)
                {
                    throw new NullReferenceException("la especie no puede ser nula");
                }
                return _repo.Guardar(entidad);

            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Veterinario> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            var lista = _repo.Consultar();
            var eliminado = lista.RemoveAll(v => v.Cedula == id) > 0;

            if (eliminado)
            {
                File.WriteAllLines(_repo._filepath, lista.Select(v => v.ToString()));
            }

            return eliminado;
        }
    }
}
