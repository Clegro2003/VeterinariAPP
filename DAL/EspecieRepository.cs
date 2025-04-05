using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EspecieRepository : FileRepository<Especie>
    {
        public EspecieRepository(string filePath) : base(filePath)
        {
        }


        public Especie BuscarProId(int id)
        {
            return Consultar().FirstOrDefault<Especie>(x => x.IdEspecie == id);
        }

        public override List<Especie> Consultar()
        {
            try
            {
                List<Especie> lista = new List<Especie>();

                StreamReader sr = new StreamReader(Archivos.ARC_ESPECIE);
                while (!sr.EndOfStream)
                {
                    lista.Add(Map(sr.ReadLine()));
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Especie Map(string datos)
        {
            Especie especie = new Especie();
            especie.IdEspecie = int.Parse(datos.Split(';')[0]);
            especie.Nombre = datos.Split(';')[1];
            return especie;
        }


    }
}
