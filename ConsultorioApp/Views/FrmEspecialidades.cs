using ConsultorioApp.Controllers;
using DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioApp.Views
{
    public partial class FrmEspecialidades : Form
    {
        EspecialidadesController _especialidadesController;
        IEnumerable<Especialidad> _especialidades;
        public FrmEspecialidades()
        {
            InitializeComponent();
            _especialidadesController = new EspecialidadesController();
        }

        private void FrmEspecialidades_Load(object sender, EventArgs e)
        {
            GetEspecialidades();
        }

        private async void GetEspecialidades()
        {
            _especialidades = await _especialidadesController.GetEspecialidades();

            if (_especialidades != null)
            {
                // create a new data grid view row
                dgridEspecialidades.DataSource = _especialidades;
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la Información", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.Show();
            this.Hide();
        }

        // get the id of selected item in DataGrid.
        private int? GetId()
        {
            try
            {
                // get the first element of row selected yhat contains the id.
                return int.Parse(dgridEspecialidades.Rows[dgridEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnAddEspec_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateEspecialidades();
            frm.ShowDialog();
            GetEspecialidades();
        }

        private void btnEditEspec_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                var frm = new FrmUpdateEspecialidades(id); // send id in constructor.
                frm.ShowDialog();
                GetEspecialidades();
            }
        }

        private async void btnEliminarEspec_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _especialidadesController.DeleteEspecialidad((int)id);
                    GetEspecialidades(); // refresh data
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para Eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
