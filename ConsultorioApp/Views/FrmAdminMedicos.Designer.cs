namespace ConsultorioApp.Views
{
    partial class FrmAdminMedicos
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
            panel1 = new Panel();
            btnCitas = new Button();
            btnPacientes = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(btnPacientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 200);
            panel1.TabIndex = 0;
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(97, 14);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(75, 23);
            btnCitas.TabIndex = 1;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(16, 14);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(75, 23);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(255, 164);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAdminMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 224);
            Controls.Add(panel1);
            Name = "FrmAdminMedicos";
            Text = "FrmAdminMedicos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCitas;
        private Button btnPacientes;
        private Button btnSalir;
    }
}