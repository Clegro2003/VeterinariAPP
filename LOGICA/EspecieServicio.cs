using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class EspecieServicio : IService<Especie>
    {
        private readonly EspecieRepository repoEspecie;

        public EspecieServicio()
        {
            repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public List<Especie> Consultar()
        {
            return repoEspecie.Consultar();
        }

        public string Guardar(Especie entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("la especie nopuede ser nula");
                }
                return repoEspecie.Guardar(entity);
            }
            catch
            {
                return null;
            }
        }
    }
} 