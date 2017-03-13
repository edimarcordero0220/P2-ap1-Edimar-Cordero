using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class Parcial2Db : DbContext 
    {
        public Parcial2Db() : base ("Constr")
        {
                
        }
        public DbSet <Entidades.Retenciones> Retenciones { get; set; }
        public DbSet <Entidades.TiposEmails>Tipos { get; set; }
        public DbSet <Entidades.Empleados> empleado { get; set; }

    }
}
