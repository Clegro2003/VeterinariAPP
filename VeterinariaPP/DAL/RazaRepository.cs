using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class RazaRepository : FileRepository<Raza>
    {
        public RazaRepository(string filePath) : base(filePath)
        {
        }

        public override List<Raza> Consultar()
        {
            try
            {
                List<Raza> lista = new List<Raza>();
                StreamReader sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Raza Mappear(string datos)
        {
            Raza raza = new Raza();
            raza.Id = int.Parse(datos.Split(';')[0]);
            raza.Nombre = datos.Split(';')[1];
            raza.AsignarEspecie(new EspecieRepository("especies.txt").BuscarPorId(int.Parse(datos.Split(';')[3])));
            return raza;
        }
    }
}
