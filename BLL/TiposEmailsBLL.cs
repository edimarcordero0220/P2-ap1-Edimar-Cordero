using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class TiposEmailsBLL
    {
        public static void Guardar(TiposEmails em)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                db.Tipos.Add(em);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Eliminar(TiposEmails em)
        {
            Parcial2Db db = new Parcial2Db();
            TiposEmails emple = db.Tipos.Find(em);

            db.Tipos.Remove(emple);
            db.SaveChanges();

        }
        public static TiposEmails Buscar(int Id)
        {
            Parcial2Db db = new Parcial2Db();
            return db.Tipos.Find(Id);
        }
        public static List<TiposEmails> GetLista(string tmp)
        {
            List<TiposEmails> lista = new List<TiposEmails>();
            Parcial2Db db = new Parcial2Db();
            lista = db.Tipos.Where(p => p.Descripcion == tmp).ToList();
            return lista;
        }
    }
}
