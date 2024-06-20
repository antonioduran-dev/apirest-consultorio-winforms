namespace ConsultorioApp.Views
{
    partial class FrmUpdatePacientes
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
            txtbEmail = new TextBox();
            txtbTelefono = new TextBox();
            txtbDireccion = new TextBox();
            cmbGenero = new ComboBox();
            dtimeDate = new DateTimePicker();
            txtbApellido = new TextBox();
            txtbNombre = new TextBox();
            btnGuardarPacientes = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txtbEmail);
            panel1.Controls.Add(txtbTelefono);
            panel1.Controls.Add(txtbDireccion);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(dtimeDate);
            panel1.Controls.Add(txtbApellido);
            panel1.Controls.Add(txtbNombre);
            panel1.Controls.Add(btnGuardarPacientes);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 369);
            panel1.TabIndex = 0;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(133, 240);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(127, 23);
            txtbEmail.TabIndex = 14;
            // 
            // txtbTelefono
            // 
            txtbTelefono.Location = new Point(133, 209);
            txtbTelefono.Name = "txtbTelefono";
            txtbTelefono.Size = new Size(127, 23);
            txtbTelefono.TabIndex = 13;
            // 
            // txtbDireccion
            // 
            txtbDireccion.Location = new Point(133, 177);
            txtbDireccion.Name = "txtbDireccion";
            txtbDireccion.Size = new Size(127, 23);
            txtbDireccion.TabIndex = 12;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Seleccione...", "M", "F" });
            cmbGenero.Location = new Point(133, 144);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(127, 23);
            cmbGenero.TabIndex = 11;
            // 
            // dtimeDate
            // 
            dtimeDate.Format = DateTimePickerFormat.Short;
            dtimeDate.Location = new Point(133, 112);
            dtimeDate.Name = "dtimeDate";
            dtimeDate.Size = new Size(127, 23);
            dtimeDate.TabIndex = 10;
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(133, 77);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(127, 23);
            txtbApellido.TabIndex = 9;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(133, 47);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(127, 23);
            txtbNombre.TabIndex = 8;
            // 
            // btnGuardarPacientes
            // 
            btnGuardarPacientes.Location = new Point(185, 278);
            btnGuardarPacientes.Name = "btnGuardarPacientes";
            btnGuardarPacientes.Size = new Size(75, 23);
            btnGuardarPacientes.TabIndex = 7;
            btnGuardarPacientes.Text = "Guardar";
            btnGuardarPacientes.UseVisualStyleBackColor = true;
            btnGuardarPacientes.Click += btnGuardarPacientes_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 240);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 112);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 147);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 177);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 209);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // FrmUpdatePacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 395);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdatePacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacientes";
            Load += FrmUpdatePacientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtbApellido;
        private TextBox txtbNombre;
        private Button btnGuardarPacientes;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtbEmail;
        private TextBox txtbTelefono;
        private TextBox txtbDireccion;
        private ComboBox cmbGenero;
        private DateTimePicker dtimeDate;
    }
}