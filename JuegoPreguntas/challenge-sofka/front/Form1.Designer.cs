namespace challenge_sofka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblInputNombreJugador = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.grpInputInicial = new System.Windows.Forms.GroupBox();
            this.lstGananciasTotales = new System.Windows.Forms.ListBox();
            this.grpPreguntas = new System.Windows.Forms.GroupBox();
            this.lblRespuestaCorrectaIncorrecta = new System.Windows.Forms.Label();
            this.btnRetirarseConLoObtenido = new System.Windows.Forms.Button();
            this.btnConfirmarRespuesta = new System.Windows.Forms.Button();
            this.rdbRespuestaCuatro = new System.Windows.Forms.RadioButton();
            this.rdbRespuestaTres = new System.Windows.Forms.RadioButton();
            this.rdbRespuestaDos = new System.Windows.Forms.RadioButton();
            this.rdbRespuestaUno = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorAcumuladoSesionActual = new System.Windows.Forms.Label();
            this.lblAcumuladoSesionActual = new System.Windows.Forms.Label();
            this.btnConfigurarJuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblJugadorActualNombre = new System.Windows.Forms.Label();
            this.grpInputInicial.SuspendLayout();
            this.grpPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(29, 66);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(112, 38);
            this.btnIniciarPartida.TabIndex = 0;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblInputNombreJugador
            // 
            this.lblInputNombreJugador.AutoSize = true;
            this.lblInputNombreJugador.Location = new System.Drawing.Point(6, 19);
            this.lblInputNombreJugador.Name = "lblInputNombreJugador";
            this.lblInputNombreJugador.Size = new System.Drawing.Size(108, 15);
            this.lblInputNombreJugador.TabIndex = 1;
            this.lblInputNombreJugador.Text = "Ingrese su nombre:";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(7, 37);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(159, 23);
            this.txtNombreJugador.TabIndex = 2;
            // 
            // grpInputInicial
            // 
            this.grpInputInicial.Controls.Add(this.txtNombreJugador);
            this.grpInputInicial.Controls.Add(this.lblInputNombreJugador);
            this.grpInputInicial.Controls.Add(this.btnIniciarPartida);
            this.grpInputInicial.Location = new System.Drawing.Point(6, 13);
            this.grpInputInicial.Name = "grpInputInicial";
            this.grpInputInicial.Size = new System.Drawing.Size(175, 142);
            this.grpInputInicial.TabIndex = 3;
            this.grpInputInicial.TabStop = false;
            // 
            // lstGananciasTotales
            // 
            this.lstGananciasTotales.FormattingEnabled = true;
            this.lstGananciasTotales.ItemHeight = 15;
            this.lstGananciasTotales.Location = new System.Drawing.Point(12, 250);
            this.lstGananciasTotales.Name = "lstGananciasTotales";
            this.lstGananciasTotales.Size = new System.Drawing.Size(157, 124);
            this.lstGananciasTotales.TabIndex = 4;
            this.lstGananciasTotales.SelectedIndexChanged += new System.EventHandler(this.lstGananciasTotales_SelectedIndexChanged);
            // 
            // grpPreguntas
            // 
            this.grpPreguntas.Controls.Add(this.lblJugadorActualNombre);
            this.grpPreguntas.Controls.Add(this.lblJugador);
            this.grpPreguntas.Controls.Add(this.lblRespuestaCorrectaIncorrecta);
            this.grpPreguntas.Controls.Add(this.btnRetirarseConLoObtenido);
            this.grpPreguntas.Controls.Add(this.btnConfirmarRespuesta);
            this.grpPreguntas.Controls.Add(this.rdbRespuestaCuatro);
            this.grpPreguntas.Controls.Add(this.rdbRespuestaTres);
            this.grpPreguntas.Controls.Add(this.rdbRespuestaDos);
            this.grpPreguntas.Controls.Add(this.rdbRespuestaUno);
            this.grpPreguntas.Controls.Add(this.lblPregunta);
            this.grpPreguntas.Controls.Add(this.label1);
            this.grpPreguntas.Controls.Add(this.lblValorAcumuladoSesionActual);
            this.grpPreguntas.Controls.Add(this.lblAcumuladoSesionActual);
            this.grpPreguntas.Location = new System.Drawing.Point(187, 12);
            this.grpPreguntas.Name = "grpPreguntas";
            this.grpPreguntas.Size = new System.Drawing.Size(424, 419);
            this.grpPreguntas.TabIndex = 5;
            this.grpPreguntas.TabStop = false;
            this.grpPreguntas.Visible = false;
            this.grpPreguntas.Enter += new System.EventHandler(this.grpPreguntas_Enter);
            // 
            // lblRespuestaCorrectaIncorrecta
            // 
            this.lblRespuestaCorrectaIncorrecta.AutoSize = true;
            this.lblRespuestaCorrectaIncorrecta.Location = new System.Drawing.Point(332, 130);
            this.lblRespuestaCorrectaIncorrecta.Name = "lblRespuestaCorrectaIncorrecta";
            this.lblRespuestaCorrectaIncorrecta.Size = new System.Drawing.Size(12, 15);
            this.lblRespuestaCorrectaIncorrecta.TabIndex = 10;
            this.lblRespuestaCorrectaIncorrecta.Text = "-";
            // 
            // btnRetirarseConLoObtenido
            // 
            this.btnRetirarseConLoObtenido.Location = new System.Drawing.Point(24, 265);
            this.btnRetirarseConLoObtenido.Name = "btnRetirarseConLoObtenido";
            this.btnRetirarseConLoObtenido.Size = new System.Drawing.Size(152, 58);
            this.btnRetirarseConLoObtenido.TabIndex = 9;
            this.btnRetirarseConLoObtenido.Text = "Retirarse con premio actual";
            this.btnRetirarseConLoObtenido.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarRespuesta
            // 
            this.btnConfirmarRespuesta.Location = new System.Drawing.Point(182, 265);
            this.btnConfirmarRespuesta.Name = "btnConfirmarRespuesta";
            this.btnConfirmarRespuesta.Size = new System.Drawing.Size(152, 58);
            this.btnConfirmarRespuesta.TabIndex = 8;
            this.btnConfirmarRespuesta.Text = "Confirmar respuesta";
            this.btnConfirmarRespuesta.UseVisualStyleBackColor = true;
            // 
            // rdbRespuestaCuatro
            // 
            this.rdbRespuestaCuatro.AutoSize = true;
            this.rdbRespuestaCuatro.Location = new System.Drawing.Point(128, 224);
            this.rdbRespuestaCuatro.Name = "rdbRespuestaCuatro";
            this.rdbRespuestaCuatro.Size = new System.Drawing.Size(84, 19);
            this.rdbRespuestaCuatro.TabIndex = 7;
            this.rdbRespuestaCuatro.TabStop = true;
            this.rdbRespuestaCuatro.Text = "respuesta 4";
            this.rdbRespuestaCuatro.UseVisualStyleBackColor = true;
            this.rdbRespuestaCuatro.CheckedChanged += new System.EventHandler(this.rdbRespuestaCuatro_CheckedChanged);
            // 
            // rdbRespuestaTres
            // 
            this.rdbRespuestaTres.AutoSize = true;
            this.rdbRespuestaTres.Location = new System.Drawing.Point(128, 199);
            this.rdbRespuestaTres.Name = "rdbRespuestaTres";
            this.rdbRespuestaTres.Size = new System.Drawing.Size(84, 19);
            this.rdbRespuestaTres.TabIndex = 6;
            this.rdbRespuestaTres.TabStop = true;
            this.rdbRespuestaTres.Text = "respuesta 3";
            this.rdbRespuestaTres.UseVisualStyleBackColor = true;
            this.rdbRespuestaTres.CheckedChanged += new System.EventHandler(this.rdbRespuestaTres_CheckedChanged);
            // 
            // rdbRespuestaDos
            // 
            this.rdbRespuestaDos.AutoSize = true;
            this.rdbRespuestaDos.Location = new System.Drawing.Point(128, 174);
            this.rdbRespuestaDos.Name = "rdbRespuestaDos";
            this.rdbRespuestaDos.Size = new System.Drawing.Size(84, 19);
            this.rdbRespuestaDos.TabIndex = 5;
            this.rdbRespuestaDos.TabStop = true;
            this.rdbRespuestaDos.Text = "respuesta 2";
            this.rdbRespuestaDos.UseVisualStyleBackColor = true;
            this.rdbRespuestaDos.CheckedChanged += new System.EventHandler(this.rdbRespuestaDos_CheckedChanged);
            // 
            // rdbRespuestaUno
            // 
            this.rdbRespuestaUno.AutoSize = true;
            this.rdbRespuestaUno.Location = new System.Drawing.Point(128, 149);
            this.rdbRespuestaUno.Name = "rdbRespuestaUno";
            this.rdbRespuestaUno.Size = new System.Drawing.Size(84, 19);
            this.rdbRespuestaUno.TabIndex = 4;
            this.rdbRespuestaUno.TabStop = true;
            this.rdbRespuestaUno.Text = "respuesta 1";
            this.rdbRespuestaUno.UseVisualStyleBackColor = true;
            this.rdbRespuestaUno.CheckedChanged += new System.EventHandler(this.rdbRespuestaUno_CheckedChanged);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(140, 79);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(12, 15);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregunta:";
            // 
            // lblValorAcumuladoSesionActual
            // 
            this.lblValorAcumuladoSesionActual.AutoSize = true;
            this.lblValorAcumuladoSesionActual.Location = new System.Drawing.Point(128, 20);
            this.lblValorAcumuladoSesionActual.Name = "lblValorAcumuladoSesionActual";
            this.lblValorAcumuladoSesionActual.Size = new System.Drawing.Size(13, 15);
            this.lblValorAcumuladoSesionActual.TabIndex = 1;
            this.lblValorAcumuladoSesionActual.Text = "0";
            // 
            // lblAcumuladoSesionActual
            // 
            this.lblAcumuladoSesionActual.AutoSize = true;
            this.lblAcumuladoSesionActual.Location = new System.Drawing.Point(24, 20);
            this.lblAcumuladoSesionActual.Name = "lblAcumuladoSesionActual";
            this.lblAcumuladoSesionActual.Size = new System.Drawing.Size(98, 15);
            this.lblAcumuladoSesionActual.TabIndex = 0;
            this.lblAcumuladoSesionActual.Text = "Total acumulado:";
            // 
            // btnConfigurarJuego
            // 
            this.btnConfigurarJuego.Location = new System.Drawing.Point(13, 161);
            this.btnConfigurarJuego.Name = "btnConfigurarJuego";
            this.btnConfigurarJuego.Size = new System.Drawing.Size(157, 83);
            this.btnConfigurarJuego.TabIndex = 6;
            this.btnConfigurarJuego.Text = "Configurar Juego";
            this.btnConfigurarJuego.UseVisualStyleBackColor = true;
            this.btnConfigurarJuego.Click += new System.EventHandler(this.btnConfigurarJuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(13, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 39);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(24, 41);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(87, 15);
            this.lblJugador.TabIndex = 11;
            this.lblJugador.Text = "Jugador actual:";
            // 
            // lblJugadorActualNombre
            // 
            this.lblJugadorActualNombre.AutoSize = true;
            this.lblJugadorActualNombre.Location = new System.Drawing.Point(117, 41);
            this.lblJugadorActualNombre.Name = "lblJugadorActualNombre";
            this.lblJugadorActualNombre.Size = new System.Drawing.Size(59, 15);
            this.lblJugadorActualNombre.TabIndex = 12;
            this.lblJugadorActualNombre.Text = "-nombre-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 440);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfigurarJuego);
            this.Controls.Add(this.grpPreguntas);
            this.Controls.Add(this.lstGananciasTotales);
            this.Controls.Add(this.grpInputInicial);
            this.Name = "Form1";
            this.Text = "Preguntas & Respuestas";
            this.grpInputInicial.ResumeLayout(false);
            this.grpInputInicial.PerformLayout();
            this.grpPreguntas.ResumeLayout(false);
            this.grpPreguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIniciarPartida;
        private Label lblInputNombreJugador;
        private TextBox txtNombreJugador;
        private GroupBox grpInputInicial;
        private ListBox lstGananciasTotales;
        private GroupBox grpPreguntas;
        private Label lblAcumuladoSesionActual;
        private Label lblValorAcumuladoSesionActual;
        private Label label1;
        private Label lblPregunta;
        private RadioButton rdbRespuestaCuatro;
        private RadioButton rdbRespuestaTres;
        private RadioButton rdbRespuestaDos;
        private RadioButton rdbRespuestaUno;
        private Button btnConfirmarRespuesta;
        private Button btnRetirarseConLoObtenido;
        private Label lblRespuestaCorrectaIncorrecta;
        private Button btnConfigurarJuego;
        private Button btnSalir;
        private Label lblJugadorActualNombre;
        private Label lblJugador;
    }
}