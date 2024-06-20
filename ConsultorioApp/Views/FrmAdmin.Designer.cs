namespace ConsultorioApp
{
    partial class FrmAdmin
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
            panel1 = new Panel();
            btnMedicos = new Button();
            btnUsuarios = new Button();
            btnEspecialidades = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnMedicos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnEspecialidades);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 347);
            panel1.TabIndex = 0;
            // 
            // btnMedicos
            // 
            btnMedicos.Location = new Point(96, 13);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(75, 23);
            btnMedicos.TabIndex = 3;
            btnMedicos.Text = "Medicos";
            btnMedicos.UseVisualStyleBackColor = true;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(15, 13);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(75, 23);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new Point(177, 13);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(99, 23);
            btnEspecialidades.TabIndex = 1;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(473, 311);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 382);
            Controls.Add(panel1);
            Name = "FrmAdmin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEspecialidades;
        private Button btnUsuarios;
        private Button btnMedicos;
        private Button btnSalir;
    }
}
