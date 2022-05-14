namespace challenge_sofka.front
{
    partial class FrmDificultades
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
            this.lstDificultades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdDificultad = new System.Windows.Forms.TextBox();
            this.txtNombreDificultad = new System.Windows.Forms.TextBox();
            this.btnAgregarDificultad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(206, 111);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstDificultades
            // 
            this.lstDificultades.FormattingEnabled = true;
            this.lstDificultades.ItemHeight = 15;
            this.lstDificultades.Location = new System.Drawing.Point(12, 127);
            this.lstDificultades.Name = "lstDificultades";
            this.lstDificultades.Size = new System.Drawing.Size(206, 319);
            this.lstDificultades.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // txtIdDificultad
            // 
            this.txtIdDificultad.Location = new System.Drawing.Point(231, 145);
            this.txtIdDificultad.Name = "txtIdDificultad";
            this.txtIdDificultad.Size = new System.Drawing.Size(168, 23);
            this.txtIdDificultad.TabIndex = 6;
            // 
            // txtNombreDificultad
            // 
            this.txtNombreDificultad.Location = new System.Drawing.Point(231, 213);
            this.txtNombreDificultad.Name = "txtNombreDificultad";
            this.txtNombreDificultad.Size = new System.Drawing.Size(168, 23);
            this.txtNombreDificultad.TabIndex = 7;
            // 
            // btnAgregarDificultad
            // 
            this.btnAgregarDificultad.Location = new System.Drawing.Point(231, 242);
            this.btnAgregarDificultad.Name = "btnAgregarDificultad";
            this.btnAgregarDificultad.Size = new System.Drawing.Size(169, 69);
            this.btnAgregarDificultad.TabIndex = 8;
            this.btnAgregarDificultad.Text = "Agregar Dificultad";
            this.btnAgregarDificultad.UseVisualStyleBackColor = true;
            this.btnAgregarDificultad.Click += new System.EventHandler(this.btnAgregarDificultad_Click);
            // 
            // FrmDificultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarDificultad);
            this.Controls.Add(this.txtNombreDificultad);
            this.Controls.Add(this.txtIdDificultad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDificultades);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmDificultades";
            this.Text = "Dificultades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private ListBox lstDificultades;
        private Label label1;
        private Label label3;
        private TextBox txtIdDificultad;
        private TextBox txtNombreDificultad;
        private Button btnAgregarDificultad;
    }
}