namespace ConsultorioApp.Views
{
    partial class FrmCitas
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
            btnEliminarCita = new Button();
            btnEditarCita = new Button();
            btnAddCita = new Button();
            btnBack = new Button();
            dgridCitas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridCitas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnEliminarCita);
            panel1.Controls.Add(btnEditarCita);
            panel1.Controls.Add(btnAddCita);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridCitas);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Location = new Point(310, 303);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(75, 23);
            btnEliminarCita.TabIndex = 4;
            btnEliminarCita.Text = "Eliminar";
            btnEliminarCita.UseVisualStyleBackColor = true;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // btnEditarCita
            // 
            btnEditarCita.Location = new Point(229, 303);
            btnEditarCita.Name = "btnEditarCita";
            btnEditarCita.Size = new Size(75, 23);
            btnEditarCita.TabIndex = 3;
            btnEditarCita.Text = "Editar";
            btnEditarCita.UseVisualStyleBackColor = true;
            btnEditarCita.Click += btnEditarCita_Click;
            // 
            // btnAddCita
            // 
            btnAddCita.Location = new Point(148, 303);
            btnAddCita.Name = "btnAddCita";
            btnAddCita.Size = new Size(75, 23);
            btnAddCita.TabIndex = 2;
            btnAddCita.Text = "Agregar";
            btnAddCita.UseVisualStyleBackColor = true;
            btnAddCita.Click += btnAddCita_Click;
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
            // dgridCitas
            // 
            dgridCitas.AllowUserToAddRows = false;
            dgridCitas.AllowUserToDeleteRows = false;
            dgridCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridCitas.Location = new Point(67, 36);
            dgridCitas.MultiSelect = false;
            dgridCitas.Name = "dgridCitas";
            dgridCitas.ReadOnly = true;
            dgridCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridCitas.Size = new Size(632, 261);
            dgridCitas.TabIndex = 0;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmCitas";
            Text = "FrmCitas";
            Load += FrmCitas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminarCita;
        private Button btnEditarCita;
        private Button btnAddCita;
        private Button btnBack;
        private DataGridView dgridCitas;
    }
}