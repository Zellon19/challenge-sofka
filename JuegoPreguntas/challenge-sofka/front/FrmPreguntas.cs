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
            bool mostrar = false;
            string mensaje = "Falta";
            if (string.IsNullOrWhiteSpace(this.txtPregunta.Text)){
                mensaje += " la pregunta,";
                mostrar = true;
            }
            if (string.IsNullOrWhiteSpace(this.txtIdPregunta.Text))
            {
                mensaje += " la id,";
                mostrar = true;
            }
            if(!this.rdbRespuestaDos.Checked && !this.rdbRespuestaCuatro.Checked &&
                !this.rdbRespuestaTres.Checked && !this.rdbRespuestaUno.Checked)
            {
                mensaje += " seleccionar la respuesta correcta,";
                mostrar = true;
            }
            if(string.IsNullOrWhiteSpace(this.txtRespuestaUno.Text) || string.IsNullOrEmpty(this.txtRespuestaDos.Text) ||
                string.IsNullOrWhiteSpace(this.txtRespuestaTres.Text) || string.IsNullOrEmpty(this.txtRespuestaCuatro.Text))
            {
                mensaje += " una o mas respuestas";
                mostrar = true;
            }

            if (mostrar)
            {
                mensaje += ".";
                MessageBox.Show(mensaje, "Error");
                return true;
            }


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
                    var mPregunta = this.txtPregunta.Text;
                    var mDificultad = this.cboDificultad.SelectedValue.ToString()[0].ToString();
                    var mCategoria = this.cboCategoria.SelectedValue.ToString()[0].ToString();
                    var mRespuestaUno = this.txtRespuestaUno.Text;
                    var mRespuestaDos = this.txtRespuestaDos.Text;
                    var mRespuestaTres = this.txtRespuestaTres.Text;
                    var mRespuestaCuatro = this.txtRespuestaCuatro.Text;
                    Respuesta res = new();
                    Categoria categoria = new Categoria().BuscarCategoria(new Categoria(int.Parse(mCategoria)));
                    Dificultad dificultad = new Dificultad().BuscarDificultad(new Dificultad(int.Parse(mDificultad)));
                    Pregunta pregunta = new(result, categoria, dificultad, 0);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
