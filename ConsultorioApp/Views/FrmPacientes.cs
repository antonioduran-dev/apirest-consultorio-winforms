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
    public partial class FrmPacientes : Form
    {
        private PacientesController _pacientesController;
        private IEnumerable<Paciente> _pacientes;
        private Medico _medico;
        public FrmPacientes(Medico medico)
        {
            InitializeComponent();
            _pacientesController = new PacientesController();
            _pacientes = new List<Paciente>();
            _medico = medico;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            GetPacientes();
        }

        private async void GetPacientes()
        {
            _pacientes = await _pacientesController.GetPacientes();

            if (_pacientes != null)
            {
                // create a new data grid source with the list given.
                dgridPacientes.DataSource = _pacientes;
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la Información", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdminMedicos(_medico);
            frm.Show();
            this.Hide();
        }

        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            FrmUpdatePacientes frm = new FrmUpdatePacientes();
            frm.ShowDialog();
            GetPacientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                FrmUpdatePacientes frm = new FrmUpdatePacientes(id);
                frm.ShowDialog();
                GetPacientes(); // refresh DataSource of DataGRid.
            }
        }

        private async void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _pacientesController.DeletePaciente((int)id);
                    GetPacientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para Eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // get the id of selected item in DataGrid.
        private int? GetId()
        {
            try
            {
                // get the first element of row selected yhat contains the id.
                return int.Parse(dgridPacientes.Rows[dgridPacientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
