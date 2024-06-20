namespace ConsultorioApp.Views
{
    partial class FrmMedicos
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
            btnAddMedico = new Button();
            btnEditMedico = new Button();
            btnEliminarMedico = new Button();
            btnBack = new Button();
            dgridMedicos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridMedicos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnAddMedico);
            panel1.Controls.Add(btnEditMedico);
            panel1.Controls.Add(btnEliminarMedico);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridMedicos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 2;
            // 
            // btnAddMedico
            // 
            btnAddMedico.Location = new Point(107, 310);
            btnAddMedico.Name = "btnAddMedico";
            btnAddMedico.Size = new Size(75, 23);
            btnAddMedico.TabIndex = 4;
            btnAddMedico.Text = "Agregar";
            btnAddMedico.UseVisualStyleBackColor = true;
            btnAddMedico.Click += btnAddMedico_Click;
            // 
            // btnEditMedico
            // 
            btnEditMedico.Location = new Point(188, 310);
            btnEditMedico.Name = "btnEditMedico";
            btnEditMedico.Size = new Size(75, 23);
            btnEditMedico.TabIndex = 3;
            btnEditMedico.Text = "Editar";
            btnEditMedico.UseVisualStyleBackColor = true;
            btnEditMedico.Click += btnEditMedico_Click;
            // 
            // btnEliminarMedico
            // 
            btnEliminarMedico.Location = new Point(269, 310);
            btnEliminarMedico.Name = "btnEliminarMedico";
            btnEliminarMedico.Size = new Size(75, 23);
            btnEliminarMedico.TabIndex = 2;
            btnEliminarMedico.Text = "Eliminar";
            btnEliminarMedico.UseVisualStyleBackColor = true;
            btnEliminarMedico.Click += btnEliminarMedico_Click;
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
            // dgridMedicos
            // 
            dgridMedicos.AllowUserToAddRows = false;
            dgridMedicos.AllowUserToDeleteRows = false;
            dgridMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridMedicos.Location = new Point(26, 20);
            dgridMedicos.MultiSelect = false;
            dgridMedicos.Name = "dgridMedicos";
            dgridMedicos.ReadOnly = true;
            dgridMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridMedicos.Size = new Size(648, 284);
            dgridMedicos.TabIndex = 0;
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmMedicos";
            Text = "FrmMedicos";
            Load += FrmMedicos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddMedico;
        private Button btnEditMedico;
        private Button btnEliminarMedico;
        private Button btnBack;
        private DataGridView dgridMedicos;
    }
}