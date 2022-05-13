using challenge_sofka.front;

namespace challenge_sofka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            this.grpInputInicial.Enabled = false;
            this.grpPreguntas.Visible = true;
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