using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;


namespace BLL
{
   public class RepositoriyBLL
    {
        public static bool Guardar(TiposEmails nuevo)
        {
            bool retornar = false;
            using (var db = new Repositorio<TiposEmails>())
            {
                retornar = db.Guardar(nuevo) != null;
            }
            return retornar;

        }
       
        public static bool Eliminar(TiposEmails Id)
        {
            bool result = false;
            using (var db = new Repositorio<TiposEmails>())
            {
                result = db.Eliminar(Id);

            }
            return result;
        }
    }
}

