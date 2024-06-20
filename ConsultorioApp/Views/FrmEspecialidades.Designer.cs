namespace ConsultorioApp.Views
{
    partial class FrmEspecialidades
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
            btnAddEspec = new Button();
            btnEditEspec = new Button();
            btnEliminarEspec = new Button();
            btnBack = new Button();
            dgridEspecialidades = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnAddEspec);
            panel1.Controls.Add(btnEditEspec);
            panel1.Controls.Add(btnEliminarEspec);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridEspecialidades);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnAddEspec
            // 
            btnAddEspec.Location = new Point(107, 310);
            btnAddEspec.Name = "btnAddEspec";
            btnAddEspec.Size = new Size(75, 23);
            btnAddEspec.TabIndex = 4;
            btnAddEspec.Text = "Agregar";
            btnAddEspec.UseVisualStyleBackColor = true;
            btnAddEspec.Click += btnAddEspec_Click;
            // 
            // btnEditEspec
            // 
            btnEditEspec.Location = new Point(188, 310);
            btnEditEspec.Name = "btnEditEspec";
            btnEditEspec.Size = new Size(75, 23);
            btnEditEspec.TabIndex = 3;
            btnEditEspec.Text = "Editar";
            btnEditEspec.UseVisualStyleBackColor = true;
            btnEditEspec.Click += btnEditEspec_Click;
            // 
            // btnEliminarEspec
            // 
            btnEliminarEspec.Location = new Point(269, 310);
            btnEliminarEspec.Name = "btnEliminarEspec";
            btnEliminarEspec.Size = new Size(75, 23);
            btnEliminarEspec.TabIndex = 2;
            btnEliminarEspec.Text = "Eliminar";
            btnEliminarEspec.UseVisualStyleBackColor = true;
            btnEliminarEspec.Click += btnEliminarEspec_Click;
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
            // dgridEspecialidades
            // 
            dgridEspecialidades.AllowUserToAddRows = false;
            dgridEspecialidades.AllowUserToDeleteRows = false;
            dgridEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridEspecialidades.Location = new Point(26, 20);
            dgridEspecialidades.MultiSelect = false;
            dgridEspecialidades.Name = "dgridEspecialidades";
            dgridEspecialidades.ReadOnly = true;
            dgridEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridEspecialidades.Size = new Size(528, 284);
            dgridEspecialidades.TabIndex = 0;
            // 
            // FrmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmEspecialidades";
            Text = "FrmEspecialidades";
            Load += FrmEspecialidades_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private DataGridView dgridEspecialidades;
        private Button btnAddEspec;
        private Button btnEditEspec;
        private Button btnEliminarEspec;
    }
}