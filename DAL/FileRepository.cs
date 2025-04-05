using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public abstract class FileRepository<T>
    {
        public string _filepath;

        protected FileRepository(string filepath)
        {
            this._filepath = filepath;
        }

        public string Guardar(T Entity)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_filepath, true);
                sw.WriteLine(Entity.ToString());
                sw.Close();
                return "Guardado";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public abstract List<T> Consultar();
        public abstract T Map(string dato);
    }
}
