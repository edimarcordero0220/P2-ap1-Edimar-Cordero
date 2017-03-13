using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static void Guardar(Empleados em)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                db.empleado.Add(em);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Eliminar(Empleados em)
        {
            Parcial2Db db = new Parcial2Db();
            Empleados emple = db.empleado.Find(em);

            db.empleado.Remove(emple);
            db.SaveChanges();

        }
        public static Empleados Buscar(int Id)
        {
            Parcial2Db db = new Parcial2Db();
            return db.empleado.Find(Id);
        }
        public static List<Empleados> GetLista(string tmp)
        {
            List<Empleados> lista = new List<Empleados>();
            Parcial2Db db = new Parcial2Db();
            lista = db.empleado.Where(p => p.Nombres == tmp).ToList();
            return lista;
        }
    }
}
