namespace ConsultorioApp.Views
{
    partial class FrmUpdateUsuarios
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
            txtbRol = new TextBox();
            txtbPassword = new TextBox();
            txtbNombreUsuario = new TextBox();
            btnGuardarUsuario = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txtbRol);
            panel1.Controls.Add(txtbPassword);
            panel1.Controls.Add(txtbNombreUsuario);
            panel1.Controls.Add(btnGuardarUsuario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 192);
            panel1.TabIndex = 1;
            // 
            // txtbRol
            // 
            txtbRol.Location = new Point(143, 96);
            txtbRol.Name = "txtbRol";
            txtbRol.Size = new Size(127, 23);
            txtbRol.TabIndex = 12;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(143, 64);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(127, 23);
            txtbPassword.TabIndex = 9;
            txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtbNombreUsuario
            // 
            txtbNombreUsuario.Location = new Point(143, 34);
            txtbNombreUsuario.Name = "txtbNombreUsuario";
            txtbNombreUsuario.Size = new Size(127, 23);
            txtbNombreUsuario.TabIndex = 8;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(195, 125);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(75, 23);
            btnGuardarUsuario.TabIndex = 7;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 99);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Usuario:";
            // 
            // FrmUpdateUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 217);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += FrmUpdateUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbRol;
        private TextBox txtbPassword;
        private TextBox txtbNombreUsuario;
        private Button btnGuardarUsuario;
        private Label label6;
        private Label label2;
        private Label label1;
    }
}