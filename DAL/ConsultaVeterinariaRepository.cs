using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ConsultaVeterinariaRepository : FileRepository<ConsultaVeterinaria>
    {
        public ConsultaVeterinariaRepository(string filepath) : base(filepath)
        {
        }

        public override List<ConsultaVeterinaria> Consultar()
        {


            try
            {
                if (File.Exists(Archivos.ARC_CONSULTAVETERINARIA))
                {
                    List<ConsultaVeterinaria> lista = new List<ConsultaVeterinaria>();

                    StreamReader sr = new StreamReader(Archivos.ARC_CONSULTAVETERINARIA);
                    while (!sr.EndOfStream)
                    {
                        lista.Add(Map(sr.ReadLine()));
                    }
                    return lista;
                }

                return null;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override ConsultaVeterinaria Map(string dato)
        {
            var partes = dato.Split(';');
            ConsultaVeterinaria consulta = new ConsultaVeterinaria();
            consulta.Diagnostico = partes[0];
            consulta.Tratamiento = partes[1];
            consulta.Fecha = DateTime.Parse(partes[2]);
            consulta.Mascota = new Mascota();
            consulta.Mascota.IdMascota = int.Parse(partes[3]);
            consulta.Veterinario = new Veterinario();
            consulta.Veterinario.Nombre = partes[4];

            return consulta;
        }
    }
}
