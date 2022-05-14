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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Categoria categorias = new();

            try
            {
                List<string> categoriasMostrarEnLista = new();
                foreach (var cat in categorias.ListaCategorias)
                {
                    categoriasMostrarEnLista.Add(cat.Id + " " + cat.Nombre);
                }
                this.lstCategorias.DataSource = categoriasMostrarEnLista;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion frm = new();
            frm.Show();
        }

        private bool FaltanDatos()
        {
            if (string.IsNullOrEmpty(this.txtIdCategoria.Text) ||
                string.IsNullOrEmpty(this.txtNombreCategoria.Text))
                return true;

            return false;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                try
                {
                    bool idParseada = int.TryParse(this.txtIdCategoria.Text, out var result);
                    if (result == 0)
                    {
                        MessageBox.Show("La id no puede ser menor a 1 (<1) ni contener letras!");
                        return;
                    }
                    string nombreCategoria = this.txtNombreCategoria.Text;

                    Categoria categoria = new(result, nombreCategoria);
                    if(categoria.BuscarCategoria(categoria) == null)
                    {
                        if (categoria.AgregarCategoria(categoria))
                        {
                            MessageBox.Show("Categoría agregada con éxito!");
                            this.CargarDatos();
                            this.txtIdCategoria.Clear();
                            this.txtNombreCategoria.Clear();
                            return;
                        }
                        MessageBox.Show("No se ha podido agregar la categoría.", "Error");
                        return;
                    }
                    MessageBox.Show("Ya existe una categoría con esa id.");
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
