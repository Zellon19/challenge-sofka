using challenge_sofka.front;
using challenge_sofka.back;

namespace challenge_sofka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarValores();
        }

        public void InicializarValores()
        {
            Categoria cat = new();
            cat.AgregarCategoria(new Categoria(1, "Cultura General"));
            cat.AgregarCategoria(new Categoria(2, "Deportes"));
            cat.AgregarCategoria(new Categoria(3, "Historia"));

            Dificultad dif = new();
            dif.AgregarDificultad(new Dificultad(1, "Fácil"));
            dif.AgregarDificultad(new Dificultad(2, "Normal"));
            dif.AgregarDificultad(new Dificultad(3, "Difícil"));
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombreJugador.Text))
            {
                MessageBox.Show("El nombre del jugador no puede estar vacío.", "Error");
                return;
            }
            Jugador jugador = new(1, this.txtNombreJugador.Text);
            if (jugador.AgregarJugador(jugador))
            {
                this.grpInputInicial.Enabled = false;
                this.grpPreguntas.Visible = true;
                Jugador actualTest = jugador.BuscarJugador(jugador);
                this.lblJugadorActualNombre.Text = actualTest.Nombre;
                this.lblValorAcumuladoSesionActual.Text = actualTest.TotalGanado.ToString();
            }
        }

        private void lstGananciasTotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfigurarJuego_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion config = new();
            config.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region ignorar
        private void rdbRespuestaUno_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rdbRespuestaDos_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void rdbRespuestaTres_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void rdbRespuestaCuatro_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void grpPreguntas_Enter(object sender, EventArgs e)
        {

        }
        #endregion

    }
}