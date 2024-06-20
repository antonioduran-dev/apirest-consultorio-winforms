using ConsultorioApp.Controllers;
using ConsultorioApp.Models;
using DB.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmMedicos : Form
    {
        private MedicosController _medicoController;
        private IEnumerable<Medico> _medicos;
        public FrmMedicos()
        {
            InitializeComponent();
            _medicoController = new MedicosController();
            _medicos = new List<Medico>();
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            GetMedicos();
        }

        private async void GetMedicos()
        {
            _medicos = await _medicoController.GetMedicos();
            List<MedicoModel> medicosModel = new List<MedicoModel>();

            if (_medicos != null)
            {
                foreach (var medico in _medicos)
                {
                    // creates new MedicoModel and adds to list.
                    medicosModel.Add(new MedicoModel
                    {
                        MedicoId = medico.MedicoId,
                        Nombre = medico.Nombre,
                        Apellido = medico.Apellido,
                        Especialidad = medico.Especialidad!.Nombre,
                        Telefono = medico.Telefono,
                        Email = medico.Email,
                        Usuario = medico.Usuario!.NombreUsuario
                    });
                }
                // create a new data grid source with the list given.
                dgridMedicos.DataSource = medicosModel;
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

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateMedicos();
            frm.ShowDialog();
            GetMedicos();
        }

        private void btnEditMedico_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                var frm = new FrmUpdateMedicos(id);
                frm.ShowDialog();
                GetMedicos();
            }
        }

        private async void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if(id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _medicoController.DeleteMedico((int)id);
                    GetMedicos();
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
                return int.Parse(dgridMedicos.Rows[dgridMedicos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
