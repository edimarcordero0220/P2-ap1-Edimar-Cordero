using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{
    public class IRepositorioy
    {
        public interface IRepositoriy<TEntity> : IDisposable where TEntity : class
        {
            TEntity Guardar(TEntity nuevo);
            bool Eliminar(TEntity Id);
            TEntity Buscar(Expression<Func<TEntity, bool>> Id);
            List<TEntity> GetList();
            //List<TEntity> GetListN(Expression<Func<TEntity, bool>> nombre);
            

        }
    }
}
