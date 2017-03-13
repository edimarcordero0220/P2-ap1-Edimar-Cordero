using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using Entidades;
using DAL;
using static DAL.IRepositorioy;

namespace BLL
{
    public class Repositorio<TEntity> : IRepositoriy<TEntity> where TEntity : class
    {

        Parcial2Db context = null;
        public Repositorio()
        {
            context = new Parcial2Db();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }
        public TEntity Guardar(TEntity n)
        {
            TEntity result = null;
            try
            {
                EntitySet.Add(n);
                context.SaveChanges();
                result = n;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
        public TEntity Buscar(Expression<Func<TEntity, bool>> id)
        {
            TEntity retornar = null;
            try
            {
                retornar = EntitySet.FirstOrDefault(id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return retornar;
        }
        public bool Eliminar(TEntity id)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(id);
                EntitySet.Remove(id);
                result = context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
        public List<TEntity> GetList()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> nombre)
        {
            try
            {
                return EntitySet.Where(nombre).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
     
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

    }
}
