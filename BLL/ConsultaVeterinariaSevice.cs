using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConsultaVeterinariaSevice : IService<ConsultaVeterinaria>
    {
        private readonly ConsultaVeterinariaRepository _repo;
        public ConsultaVeterinariaSevice()
        {
            _repo = new ConsultaVeterinariaRepository(Archivos.ARC_CONSULTAVETERINARIA);
        }

        public List<ConsultaVeterinaria> Consultar()
        {
            return _repo.Consultar();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(ConsultaVeterinaria entidad)
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
    }
}
