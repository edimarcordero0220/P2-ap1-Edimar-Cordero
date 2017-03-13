using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Parcial2Ap2_EdimarCM.Registros
{
    public partial class Tipos_Emails : Form
    {
        public Tipos_Emails()
        {
            InitializeComponent();
        }
        Utilidades util = new Utilidades();
        private void LlenarClase(TiposEmails e)
        {
            e.Descripcion = DescripciontextBox.Text;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposEmails email = new TiposEmails();
            LlenarClase(email);
            TiposEmailsBLL.Guardar(email);
            MessageBox.Show("Registro fue realizado Exitosamente!!!");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtextBox.Text);
            using (var db = new Repositorio<TiposEmails>())
            {
                if (db.Eliminar(db.Buscar(p => p.TipoId == id)))
                {

                    MessageBox.Show("eliminado con exito.");
                    
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtextBox.Text);
            TiposEmails tipos;
            using (var db = new BLL.Repositorio<TiposEmails>())
            {
                tipos = db.Buscar(p => p.TipoId == id);
                if (tipos != null)
                {
                    DescripciontextBox.Text = tipos.Descripcion;
                    
                    MessageBox.Show("Empleado Buscado");
                }
                else
                {
                    MessageBox.Show("Empleado No Existe, favor verifique el Id");
                }
            }
        }
    }
        }
    

