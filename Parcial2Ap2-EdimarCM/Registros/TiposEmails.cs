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
            e.Descripcion =DescripciontextBox.Text ;
            

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
            }
        }
    }

