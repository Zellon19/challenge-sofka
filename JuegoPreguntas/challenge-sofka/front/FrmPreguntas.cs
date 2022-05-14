using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using challenge_sofka.back;

namespace challenge_sofka.front
{
    public partial class FrmPreguntas : Form
    {
        public FrmPreguntas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Categoria categoria = new();
            Dificultad dificultad = new();

            List<string> categoriasMostrarEnCombo = new();
            foreach(var cat in categoria.ListaCategorias)
            {
                categoriasMostrarEnCombo.Add(cat.Id + " " + cat.Nombre);
            }

            List<string> dificultadesMostrarEnCombo = new();
            foreach(var dif in dificultad.ListaDificultades)
            {
                dificultadesMostrarEnCombo.Add(dif.Id + " " + dif.Nombre);
            }

            this.cboCategoria.DataSource = categoriasMostrarEnCombo;
            this.cboDificultad.DataSource = dificultadesMostrarEnCombo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion frm = new();
            frm.Show();
        }

        private bool FaltanDatos()
        {
            if (string.IsNullOrEmpty(this.txtPregunta.Text) || (!this.rdbRespuesta2.Checked &&
                !this.rdbRespuestaCuatro.Checked && !this.rdbRespuestaTres.Checked && !this.rdbRespuestaUno.Checked))
                return true;

            return false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                try
                {
                    bool mTryParseId = int.TryParse(this.txtIdPregunta.Text, out int result);
                    if (result < 1)
                    {
                        MessageBox.Show("La id no puede ser menor a 1 ni contener letras!");
                        return;
                    }
                    string mPregunta = this.txtPregunta.Text;
                    var mDificultad = this.cboDificultad.SelectedItem;
                    var mCategoria = this.cboCategoria.SelectedItem;
                    
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
    }
}
