namespace ConsultorioApp.Views
{
    partial class FrmUpdateEspecialidades
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
            txtbNombreEspec = new TextBox();
            btnGuardarEspec = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txtbNombreEspec);
            panel1.Controls.Add(btnGuardarEspec);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 146);
            panel1.TabIndex = 1;
            // 
            // txtbNombreEspec
            // 
            txtbNombreEspec.Location = new Point(133, 47);
            txtbNombreEspec.Name = "txtbNombreEspec";
            txtbNombreEspec.Size = new Size(127, 23);
            txtbNombreEspec.TabIndex = 8;
            // 
            // btnGuardarEspec
            // 
            btnGuardarEspec.Location = new Point(185, 76);
            btnGuardarEspec.Name = "btnGuardarEspec";
            btnGuardarEspec.Size = new Size(75, 23);
            btnGuardarEspec.TabIndex = 7;
            btnGuardarEspec.Text = "Guardar";
            btnGuardarEspec.UseVisualStyleBackColor = true;
            btnGuardarEspec.Click += btnGuardarEspec_Click;
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
            // FrmUpdateEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 170);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateEspecialidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Especialidades";
            Load += FrmUpdateEspecialidades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbNombreEspec;
        private Button btnGuardarEspec;
        private Label label1;
    }
}