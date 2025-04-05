using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
        public class RazaRepository : FileRepository<Raza>
        {
            public RazaRepository(string filePath) : base(filePath) { }

            public override List<Raza> Consultar()
            {
            try
            {
                List<Raza> lista = new List<Raza>();

                StreamReader sr = new StreamReader(Archivos.ARC_RAZA);
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

        public override Raza Map(string dato)
        {
            var partes = dato.Split(';');
            Raza raza = new Raza();
            raza.Nombre = partes[0];
            raza.Especie = new Especie();
            raza.Especie.Nombre = partes[1];
            return raza;
        }
    }
    }

