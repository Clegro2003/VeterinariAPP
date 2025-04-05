using ENTITY;
using System.Collections.Generic;

namespace LOGICA
{
    public interface IService<T>
    {

        string Guardar(T entity);
        List<T> Consultar();
    }
}