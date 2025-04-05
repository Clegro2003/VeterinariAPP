using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class EspecieRepository : FileRepository<Especie>
    {
        public EspecieRepository(string filePath) : base(filePath)
        {
        }

        public override List<Especie> Consultar()
        {
            try
            {
                List<Especie> lista = new List<Especie>();
                StreamReader sr = new StreamReader(filePath);

                while (! sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public override Especie Mappear(string datos)
        {
            Especie especie = new Especie();
            especie.Id = int.Parse(datos.Split(';')[0]);
            especie.Nombre = datos.Split(';')[1];
            return especie;
        }

        public Especie BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Especie>(x => x.Id == id);
        }
    }
}
