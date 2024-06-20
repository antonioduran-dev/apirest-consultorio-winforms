using ConsultorioApp.Controllers;
using DB.Models;


namespace ConsultorioApp.Views
{
    public partial class FrmUpdatePacientes : Form
    {
        private int? _id;
        private PacientesController _pacientesController;
        public FrmUpdatePacientes(int? id = null)
        {
            InitializeComponent();
            _pacientesController = new PacientesController();
            _id = id;

            if (_id != null)
                LoadData();
        }


        private async void LoadData()
        {
            Paciente paciente = await _pacientesController.GetPaciente((int)_id!);

            txtbNombre.Text = paciente.Nombre;
            txtbApellido.Text = paciente.Apellido;
            dtimeDate.Value = paciente.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
            cmbGenero.SelectedItem = paciente.Genero.ToString();
            txtbDireccion.Text = paciente.Direccion;
            txtbTelefono.Text = paciente.Telefono;
            txtbEmail.Text = paciente.Email;
        }

        private async void btnGuardarPacientes_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            string apellido = txtbApellido.Text;
            var fechaNacimiento = DateOnly.FromDateTime(dtimeDate.Value); // convert datetime to dateonly.
            int genero = cmbGenero.SelectedIndex;
            string direccion = txtbDireccion.Text;
            string telefono = txtbTelefono.Text;
            string email = txtbEmail.Text;

            if (_id == null)
            {
                if (nombre.Trim() != "" && apellido.Trim() != "" && genero != 0)
                {
                    Paciente paciente = new Paciente()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento,
                        Genero = char.Parse(cmbGenero.SelectedItem!.ToString()!),
                        Direccion = direccion,
                        Telefono = telefono,
                        Email = email
                    };

                    await _pacientesController.AddPaciente(paciente);

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
                if (nombre.Trim() != "" && apellido.Trim() != "" && genero != 0)
                {
                    Paciente paciente = new Paciente()
                    {
                        PacienteId = (int)_id,
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento,
                        Genero = char.Parse(cmbGenero.SelectedItem!.ToString()!),
                        Direccion = direccion,
                        Telefono = telefono,
                        Email = email
                    };

                    await _pacientesController.UpdatePaciente(paciente);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmUpdatePacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
