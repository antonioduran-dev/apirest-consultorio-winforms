namespace ConsultorioApp.Views
{
    partial class FrmUpdateMedicos
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
            cmbEspecialidades = new ComboBox();
            label4 = new Label();
            txtbEmailMedico = new TextBox();
            txtbTelefonoMedico = new TextBox();
            txtbApellidoMedico = new TextBox();
            txtbNombreMedico = new TextBox();
            btnGuardarMedico = new Button();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbUsuarioMedico = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(cmbUsuarioMedico);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbEspecialidades);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtbEmailMedico);
            panel1.Controls.Add(txtbTelefonoMedico);
            panel1.Controls.Add(txtbApellidoMedico);
            panel1.Controls.Add(txtbNombreMedico);
            panel1.Controls.Add(btnGuardarMedico);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 286);
            panel1.TabIndex = 1;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Items.AddRange(new object[] { "Seleccione..." });
            cmbEspecialidades.Location = new Point(107, 164);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(127, 23);
            cmbEspecialidades.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 167);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 15;
            label4.Text = "Especialidad:";
            // 
            // txtbEmailMedico
            // 
            txtbEmailMedico.Location = new Point(107, 135);
            txtbEmailMedico.Name = "txtbEmailMedico";
            txtbEmailMedico.Size = new Size(127, 23);
            txtbEmailMedico.TabIndex = 14;
            // 
            // txtbTelefonoMedico
            // 
            txtbTelefonoMedico.Location = new Point(107, 104);
            txtbTelefonoMedico.Name = "txtbTelefonoMedico";
            txtbTelefonoMedico.Size = new Size(127, 23);
            txtbTelefonoMedico.TabIndex = 13;
            // 
            // txtbApellidoMedico
            // 
            txtbApellidoMedico.Location = new Point(107, 75);
            txtbApellidoMedico.Name = "txtbApellidoMedico";
            txtbApellidoMedico.Size = new Size(127, 23);
            txtbApellidoMedico.TabIndex = 9;
            // 
            // txtbNombreMedico
            // 
            txtbNombreMedico.Location = new Point(107, 45);
            txtbNombreMedico.Name = "txtbNombreMedico";
            txtbNombreMedico.Size = new Size(127, 23);
            txtbNombreMedico.TabIndex = 8;
            // 
            // btnGuardarMedico
            // 
            btnGuardarMedico.Location = new Point(159, 235);
            btnGuardarMedico.Name = "btnGuardarMedico";
            btnGuardarMedico.Size = new Size(75, 23);
            btnGuardarMedico.TabIndex = 7;
            btnGuardarMedico.Text = "Guardar";
            btnGuardarMedico.UseVisualStyleBackColor = true;
            btnGuardarMedico.Click += btnGuardarMedico_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 135);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 104);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // cmbUsuarioMedico
            // 
            cmbUsuarioMedico.FormattingEnabled = true;
            cmbUsuarioMedico.Items.AddRange(new object[] { "Seleccione..." });
            cmbUsuarioMedico.Location = new Point(107, 193);
            cmbUsuarioMedico.Name = "cmbUsuarioMedico";
            cmbUsuarioMedico.Size = new Size(127, 23);
            cmbUsuarioMedico.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 196);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 17;
            label5.Text = "Usuario:";
            // 
            // FrmUpdateMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 310);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMedicos";
            Text = "FrmUpdateMedicos";
            Load += FrmUpdateMedicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbEmailMedico;
        private TextBox txtbTelefonoMedico;
        private TextBox txtbApellidoMedico;
        private TextBox txtbNombreMedico;
        private Button btnGuardarMedico;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbEspecialidades;
        private Label label4;
        private ComboBox cmbUsuarioMedico;
        private Label label5;
    }
}