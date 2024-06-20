namespace ConsultorioApp.Views
{
    partial class FrmPacientes
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
            btnEditar = new Button();
            btnAddPaciente = new Button();
            btnBack = new Button();
            dgridPacientes = new DataGridView();
            btnEliminarPaciente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnEliminarPaciente);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAddPaciente);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridPacientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(229, 303);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAddPaciente
            // 
            btnAddPaciente.Location = new Point(148, 303);
            btnAddPaciente.Name = "btnAddPaciente";
            btnAddPaciente.Size = new Size(75, 23);
            btnAddPaciente.TabIndex = 2;
            btnAddPaciente.Text = "Agregar";
            btnAddPaciente.UseVisualStyleBackColor = true;
            btnAddPaciente.Click += btnAddPaciente_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(67, 303);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridPacientes
            // 
            dgridPacientes.AllowUserToAddRows = false;
            dgridPacientes.AllowUserToDeleteRows = false;
            dgridPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridPacientes.Location = new Point(67, 36);
            dgridPacientes.MultiSelect = false;
            dgridPacientes.Name = "dgridPacientes";
            dgridPacientes.ReadOnly = true;
            dgridPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridPacientes.Size = new Size(632, 261);
            dgridPacientes.TabIndex = 0;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(310, 303);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(75, 23);
            btnEliminarPaciente.TabIndex = 4;
            btnEliminarPaciente.Text = "Eliminar";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmPacientes";
            Text = "FrmPacientes";
            Load += FrmPacientes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddPaciente;
        private Button btnBack;
        private DataGridView dgridPacientes;
        private Button btnEditar;
        private Button btnEliminarPaciente;
    }
}