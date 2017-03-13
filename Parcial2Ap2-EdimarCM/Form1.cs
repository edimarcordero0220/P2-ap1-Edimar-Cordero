using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial2Ap2_EdimarCM.Registros;

namespace Parcial2Ap2_EdimarCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiposDeEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tipos_Emails re = new Tipos_Emails();

            re.Show();
        }
    }
}
