using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MascotaRepository : FileRepository<Mascota>
    {
        private readonly PropietarioRepository propietarioRepo;
        private readonly RazaRepository razaRepo;

        public MascotaRepository(string filePath, PropietarioRepository propietarioRepo, RazaRepository razaRepo)
            : base(filePath)
        {
            this.propietarioRepo = propietarioRepo;
            this.razaRepo = razaRepo;
        }

        public override List<Mascota> Consultar()
        {
            try
            {
                List<Mascota> lista = new List<Mascota>();

                StreamReader sr = new StreamReader(Archivos.ARC_MASCOTA);
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
        

        public override Mascota Map(string dato)
        {
            var partes = dato.Split(';');
            Mascota mascota = new Mascota();
            mascota.IdMascota = int.Parse(partes[0]);
            mascota.Edad = int.Parse(partes[1]);
            mascota.Nombre = partes[2];
            mascota.Propietario = new Propietario();
            mascota.Propietario.Nombre = partes[3];
            mascota.Raza = new Raza();
            mascota.Raza.Nombre = partes[4];

            return mascota;

        }
    }
}
