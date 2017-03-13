using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using Entidades;
using DAL;


namespace BLL
{
    public class Repositorio<TEntity> 
    {/*
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
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

       
    }*/

}
