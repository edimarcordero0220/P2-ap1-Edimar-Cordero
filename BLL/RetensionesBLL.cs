using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class RetensionesBLL
    {
        public static void Guardar(Retenciones em)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                db.Retenciones.Add(em);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Eliminar(Retenciones em)
        {
            Parcial2Db db = new Parcial2Db();
            Retenciones emple = db.Retenciones.Find(em);

            db.Retenciones.Remove(emple);
            db.SaveChanges();

        }
        public static Retenciones Buscar(int Id)
        {
            Parcial2Db db = new Parcial2Db();
            return db.Retenciones.Find(Id);
        }
        public static List<Retenciones> GetLista(string tmp)
        {
            List<Retenciones> lista = new List<Retenciones>();
            Parcial2Db db = new Parcial2Db();
            lista = db.Retenciones.Where(p => p.Descripcion == tmp).ToList();
            return lista;
        }
    }
}
