using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeterinarioRepository : FileRepository<Veterinario>
    {
        public VeterinarioRepository(string filepath) : base(filepath)
        {
        }

        public override List<Veterinario> Consultar()
        {
            try
            {
                List<Veterinario> list = new List<Veterinario>();
                StreamReader sr = new StreamReader(_filepath);
                while (!sr.EndOfStream)
                {
                    list.Add(Map(sr.ReadLine()));
                }
                sr.Close();
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public override Veterinario Map(string dato)
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(dato.Split(';')[0]);
            veterinario.Nombre = dato.Split(';')[1];
            veterinario.Telefono = int.Parse(dato.Split(';')[2]);
            veterinario.Especialidad = dato.Split(';')[3];

            return veterinario;
        }
    }
}
