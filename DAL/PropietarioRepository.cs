using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public class PropietarioRepository : FileRepository<Propietario>
    {
        public PropietarioRepository(string filePath) : base(filePath) { }

        public override List<Propietario> Consultar()
        {
            try
            {
                if (File.Exists(Archivos.ARC_PROPIETARIO))
                {
                    List<Propietario> list = new List<Propietario>();
                    StreamReader sr = new StreamReader(_filepath);
                    while (!sr.EndOfStream)
                    {
                        list.Add(Map(sr.ReadLine()));
                    }
                    sr.Close();
                    return list;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception("Error al consultar propietarios", e);
            }

        }

        public override Propietario Map(string dato)
        {
            var partes = dato.Split(';');
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(partes[0]);
            propietario.Nombre = partes[1];
            propietario.Apellido = partes[2];
            propietario.Telefono = long.Parse(partes[3]);
            return propietario;
        }
    }
}