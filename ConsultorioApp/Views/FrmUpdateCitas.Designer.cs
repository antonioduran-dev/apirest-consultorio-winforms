namespace ConsultorioApp.Views
{
    partial class FrmUpdateCitas
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
            btnGuardarCita = new Button();
            txtbMotivoCita = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtimePickHoraCita = new DateTimePicker();
            label3 = new Label();
            dtimePickCita = new DateTimePicker();
            label1 = new Label();
            cmbPacientes = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnGuardarCita);
            panel1.Controls.Add(txtbMotivoCita);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtimePickHoraCita);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtimePickCita);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbPacientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 308);
            panel1.TabIndex = 0;
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.Location = new Point(239, 265);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(75, 23);
            btnGuardarCita.TabIndex = 10;
            btnGuardarCita.Text = "Guardar";
            btnGuardarCita.UseVisualStyleBackColor = true;
            btnGuardarCita.Click += btnGuardarCita_Click;
            // 
            // txtbMotivoCita
            // 
            txtbMotivoCita.Location = new Point(113, 169);
            txtbMotivoCita.Multiline = true;
            txtbMotivoCita.Name = "txtbMotivoCita";
            txtbMotivoCita.Size = new Size(201, 90);
            txtbMotivoCita.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 203);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "Motivo Cita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 131);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Hora Cita:";
            // 
            // dtimePickHoraCita
            // 
            dtimePickHoraCita.Format = DateTimePickerFormat.Time;
            dtimePickHoraCita.Location = new Point(113, 123);
            dtimePickHoraCita.Name = "dtimePickHoraCita";
            dtimePickHoraCita.ShowUpDown = true;
            dtimePickHoraCita.Size = new Size(121, 23);
            dtimePickHoraCita.TabIndex = 6;
            dtimePickHoraCita.Value = new DateTime(2024, 6, 17, 9, 14, 18, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 97);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha Cita:";
            // 
            // dtimePickCita
            // 
            dtimePickCita.Format = DateTimePickerFormat.Short;
            dtimePickCita.Location = new Point(113, 91);
            dtimePickCita.Name = "dtimePickCita";
            dtimePickCita.Size = new Size(121, 23);
            dtimePickCita.TabIndex = 4;
            dtimePickCita.Value = new DateTime(2024, 6, 17, 9, 14, 18, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 59);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Paciente:";
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Items.AddRange(new object[] { "Seleccione..." });
            cmbPacientes.Location = new Point(113, 56);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(121, 23);
            cmbPacientes.TabIndex = 0;
            // 
            // FrmUpdateCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 332);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUpdateCitas";
            Load += FrmUpdateCitas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbPacientes;
        private Label label4;
        private DateTimePicker dtimePickHoraCita;
        private Label label3;
        private DateTimePicker dtimePickCita;
        private Button btnGuardarCita;
        private TextBox txtbMotivoCita;
        private Label label5;
    }
}