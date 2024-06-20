using ConsultorioApp.Controllers;
using DB.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmUpdateEspecialidades : Form
    {
        private int? _id;
        private EspecialidadesController _especialidadController;
        public FrmUpdateEspecialidades(int? id = null)
        {
            InitializeComponent();
            _especialidadController = new EspecialidadesController();
            _id = id;

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateEspecialidades_Load(object sender, EventArgs e)
        {

        }

        private async void LoadData()
        {
            Especialidad especialidad = await _especialidadController.GetEspecialidad((int)_id!);
            txtbNombreEspec.Text = especialidad.Nombre;
        }

        private async void btnGuardarEspec_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombreEspec.Text;

            if (_id == null)
            {
                if (nombre.Trim() != "")
                {
                    Especialidad especialidad = new Especialidad()
                    {
                        Nombre = nombre
                    };

                    await _especialidadController.AddEspecialidad(especialidad);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (nombre.Trim() != "")
                {
                    Especialidad espec = new Especialidad()
                    {
                        EspecialidadId = (int)_id,
                        Nombre = nombre
                    };

                    await _especialidadController.UpdateEspecialidad(espec);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
