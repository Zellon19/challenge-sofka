using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenge_sofka.front
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new();
            frm.Show();
        }

        private void btnAniadirPregunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPreguntas frm = new();
            frm.Show();
        }

        private void btnAniadirCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCategorias frm = new();
            frm.Show();
        }

        private void btnAniadirDificultad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDificultades frm = new();
            frm.Show();
        }
    }
}
