namespace challenge_sofka.front
{
    partial class frmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAniadirPregunta = new System.Windows.Forms.Button();
            this.btnAniadirDificultad = new System.Windows.Forms.Button();
            this.btnAniadirCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(193, 102);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver al juego";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAniadirPregunta
            // 
            this.btnAniadirPregunta.Location = new System.Drawing.Point(12, 120);
            this.btnAniadirPregunta.Name = "btnAniadirPregunta";
            this.btnAniadirPregunta.Size = new System.Drawing.Size(193, 51);
            this.btnAniadirPregunta.TabIndex = 1;
            this.btnAniadirPregunta.Text = "Añadir pregunta";
            this.btnAniadirPregunta.UseVisualStyleBackColor = true;
            this.btnAniadirPregunta.Click += new System.EventHandler(this.btnAniadirPregunta_Click);
            // 
            // btnAniadirDificultad
            // 
            this.btnAniadirDificultad.Location = new System.Drawing.Point(12, 234);
            this.btnAniadirDificultad.Name = "btnAniadirDificultad";
            this.btnAniadirDificultad.Size = new System.Drawing.Size(193, 51);
            this.btnAniadirDificultad.TabIndex = 2;
            this.btnAniadirDificultad.Text = "Añadir Dificultad";
            this.btnAniadirDificultad.UseVisualStyleBackColor = true;
            this.btnAniadirDificultad.Click += new System.EventHandler(this.btnAniadirDificultad_Click);
            // 
            // btnAniadirCategoria
            // 
            this.btnAniadirCategoria.Location = new System.Drawing.Point(12, 177);
            this.btnAniadirCategoria.Name = "btnAniadirCategoria";
            this.btnAniadirCategoria.Size = new System.Drawing.Size(193, 51);
            this.btnAniadirCategoria.TabIndex = 3;
            this.btnAniadirCategoria.Text = "Añadir categoría";
            this.btnAniadirCategoria.UseVisualStyleBackColor = true;
            this.btnAniadirCategoria.Click += new System.EventHandler(this.btnAniadirCategoria_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(215, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnAniadirCategoria);
            this.Controls.Add(this.btnAniadirDificultad);
            this.Controls.Add(this.btnAniadirPregunta);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmConfiguracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVolver;
        private Button btnAniadirPregunta;
        private Button btnAniadirDificultad;
        private Button btnAniadirCategoria;
    }
}