using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;
namespace DAL
{
    public abstract class FileRepository<T>
    {
        protected string filePath;

        public FileRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public string Guardar(T entity)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(entity.ToString());
                sw.Close();
                return "ok";
            }
            catch (Exception)
            {
                return "error al guardar";
            }
        }
        public abstract List<T> Consultar();
        public abstract T Mappear(string datos);
    }
}
