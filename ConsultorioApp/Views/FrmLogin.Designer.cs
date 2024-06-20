namespace ConsultorioApp.Views
{
    partial class FrmLogin
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
            btnLogin = new Button();
            label2 = new Label();
            txtbPassword = new TextBox();
            label1 = new Label();
            txtbNombreUsuario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbNombreUsuario);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 274);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(126, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 27);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 138);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(126, 165);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(110, 23);
            txtbPassword.TabIndex = 2;
            txtbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 81);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario";
            // 
            // txtbNombreUsuario
            // 
            txtbNombreUsuario.Location = new Point(126, 99);
            txtbNombreUsuario.Name = "txtbNombreUsuario";
            txtbNombreUsuario.Size = new Size(110, 23);
            txtbNombreUsuario.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 298);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtbPassword;
        private Label label1;
        private TextBox txtbNombreUsuario;
        private Button btnLogin;
    }
}