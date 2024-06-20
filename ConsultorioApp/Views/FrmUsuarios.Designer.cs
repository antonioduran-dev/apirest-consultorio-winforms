namespace ConsultorioApp.Views
{
    partial class FrmUsuarios
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
            btnAddUsuario = new Button();
            btnEditUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnBack = new Button();
            dgridUsuarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnAddUsuario);
            panel1.Controls.Add(btnEditUsuario);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridUsuarios);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.Location = new Point(107, 310);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(75, 23);
            btnAddUsuario.TabIndex = 4;
            btnAddUsuario.Text = "Agregar";
            btnAddUsuario.UseVisualStyleBackColor = true;
            btnAddUsuario.Click += btnAddUsuario_Click;
            // 
            // btnEditUsuario
            // 
            btnEditUsuario.Location = new Point(188, 310);
            btnEditUsuario.Name = "btnEditUsuario";
            btnEditUsuario.Size = new Size(75, 23);
            btnEditUsuario.TabIndex = 3;
            btnEditUsuario.Text = "Editar";
            btnEditUsuario.UseVisualStyleBackColor = true;
            btnEditUsuario.Click += btnEditUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(269, 310);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 2;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 310);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridUsuarios
            // 
            dgridUsuarios.AllowUserToAddRows = false;
            dgridUsuarios.AllowUserToDeleteRows = false;
            dgridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridUsuarios.Location = new Point(26, 20);
            dgridUsuarios.MultiSelect = false;
            dgridUsuarios.Name = "dgridUsuarios";
            dgridUsuarios.ReadOnly = true;
            dgridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridUsuarios.Size = new Size(648, 284);
            dgridUsuarios.TabIndex = 0;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddUsuario;
        private Button btnEditUsuario;
        private Button btnEliminarUsuario;
        private Button btnBack;
        private DataGridView dgridUsuarios;
    }
}