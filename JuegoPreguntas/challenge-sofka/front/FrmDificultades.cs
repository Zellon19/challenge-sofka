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
    public partial class FrmDificultades : Form
    {
        public FrmDificultades()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Dificultad dificultad = new();

            List<string> dificultadesMostrarEnLista = new();
            foreach (var dif in dificultad.ListaDificultades)
            {
                dificultadesMostrarEnLista.Add(dif.Id + " " + dif.Nombre);
            }

            this.lstDificultades.DataSource = dificultadesMostrarEnLista;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion frm = new();
            frm.Show();
        }

        private bool FaltanDatos()
        {
            if (string.IsNullOrEmpty(this.txtIdDificultad.Text) || 
                string.IsNullOrEmpty(this.txtNombreDificultad.Text))
                return true;

            return false;
        }

        private void btnAgregarDificultad_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                try
                {
                    bool tryParseId = int.TryParse(this.txtIdDificultad.Text, out int result);
                    if(result == 0)
                    {
                        MessageBox.Show("La id no puede ser menor a 1 (<1) ni contener letras!");
                        return;
                    }
                    string mNombreDificultad = this.txtNombreDificultad.Text;
                    Dificultad dificultad = new(result, mNombreDificultad);
                    if (dificultad.BuscarDificultad(dificultad) == null)
                    {
                        if (dificultad.AgregarDificultad(dificultad))
                        {
                            this.CargarDatos();
                            MessageBox.Show("Dificultad agregada con éxito!");
                            this.txtIdDificultad.Clear();
                            this.txtNombreDificultad.Clear();
                            return;
                        }
                        MessageBox.Show("No se ha podido agregar la dificultad.");
                        return;
                    }
                    MessageBox.Show("Ya existe una dificultad con esa id");
                    return;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            MessageBox.Show("Falta la id y/o el nombre.", "Error");
        }
    }
}
