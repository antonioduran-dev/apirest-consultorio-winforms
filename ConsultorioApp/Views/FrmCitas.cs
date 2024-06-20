using DB.Models;
using ConsultorioApp.Controllers;
using ConsultorioApp.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmCitas : Form
    {
        private CitasController _citaController;
        private MedicosController _medicosController;
        private IEnumerable<Cita> _citas;
        private Medico _medico;
        public FrmCitas(Medico medico)
        {
            InitializeComponent();
            _citaController = new CitasController();
            _medicosController = new MedicosController();
            _citas = new List<Cita>();
            _medico = medico;
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            GetCitas();
        }

        private async void GetCitas()
        {
            _citas = await _medicosController.GetCitasByMedicoId(_medico.MedicoId);
            List<CitaModel> citasModel = new List<CitaModel>();

            if (_citas != null)
            {
                foreach (var cita in _citas)
                {
                    // creates new MedicoModel and adds to list.
                    citasModel.Add(new CitaModel
                    {
                        CitaId = cita.CitaId,
                        NombrePaciente = cita.Paciente.Nombre,
                        NombreMedico = _medico.Nombre,
                        FechaCita = cita.FechaCita,
                        HoraCita = cita.HoraCita,
                        MotivoCita = cita.MotivoCita
                    });
                }
                // create a new data grid source with the list given.
                dgridCitas.DataSource = citasModel;
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

        private void btnAddCita_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateCitas(_medico);
            frm.ShowDialog();
            GetCitas();
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if(id != null)
            {
                var frm = new FrmUpdateCitas(_medico, id);
                frm.ShowDialog();
                GetCitas();
            }
        }

        private async void btnEliminarCita_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _citaController.DeleteCita((int)id);
                    GetCitas();
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
                return int.Parse(dgridCitas.Rows[dgridCitas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
