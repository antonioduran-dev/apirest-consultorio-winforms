using ConsultorioApp.Controllers;
using DB.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmUpdateMedicos : Form
    {
        private int? _id;
        private MedicosController _medicoController;
        private UsuariosController _usuariosController;
        private EspecialidadesController _especialidadController;
        private IEnumerable<Especialidad> _especialidades = new List<Especialidad>();
        private IEnumerable<Usuario> _usuarios = new List<Usuario>();

        public FrmUpdateMedicos(int? id = null)
        {
            InitializeComponent();
            _medicoController = new MedicosController();
            _usuariosController = new UsuariosController();
            _especialidadController = new EspecialidadesController();
            _id = id;

            cmbEspecialidades.SelectedIndex = 0;
            cmbUsuarioMedico.SelectedIndex = 0;

            SetEspecialidades();
            SetUsuarios();

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateMedicos_Load(object sender, EventArgs e)
        {
        }

        private async void SetEspecialidades()
        {
            _especialidades = await _especialidadController.GetEspecialidades();

            if (_especialidades != null)
            {
                foreach (var especialidad in _especialidades)
                {
                    cmbEspecialidades.Items.Add(especialidad.Nombre);
                }
            }
        }

        private async void SetUsuarios()
        {
            _usuarios = await _usuariosController.GetUsuarios();

            if (_usuarios != null)
            {
                foreach (var usuario in _usuarios)
                {
                    cmbUsuarioMedico.Items.Add(usuario.NombreUsuario);
                }
            }
        }

        private async void LoadData()
        {
            Medico medico = await _medicoController.GetMedico((int)_id!);

            txtbNombreMedico.Text = medico.Nombre;
            txtbApellidoMedico.Text = medico.Apellido;
            txtbTelefonoMedico.Text = medico.Telefono;
            txtbEmailMedico.Text = medico.Email;
            cmbEspecialidades.SelectedItem = medico.Especialidad!.Nombre;
            cmbUsuarioMedico.SelectedItem = medico.Usuario!.NombreUsuario;
        }

        private async void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombreMedico.Text;
            string apellido = txtbApellidoMedico.Text;
            string telefono = txtbTelefonoMedico.Text;
            string email = txtbEmailMedico.Text;

            if(cmbEspecialidades.SelectedIndex != 0 && cmbUsuarioMedico.SelectedIndex != 0)
            {
                var espec = _especialidades.First(e => e.Nombre == cmbEspecialidades.SelectedItem!.ToString());
                var usuario = _usuarios.First(u => u.NombreUsuario == cmbUsuarioMedico.SelectedItem!.ToString());
                if (_id == null)
                {
                    if (nombre.Trim() != "" && apellido.Trim() != "" && cmbEspecialidades.SelectedIndex != 0)
                    {
                        Medico medico = new Medico()
                        {
                            Nombre = nombre,
                            Apellido = apellido,
                            Telefono = telefono,
                            Email = email,
                            EspecialidadId = espec.EspecialidadId,
                            UsuarioId = usuario.UsuarioId
                        };

                        await _medicoController.AddMedico(medico);

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
                    if (nombre.Trim() != "" && apellido.Trim() != "")
                    {
                        Medico medico = new Medico()
                        {
                            MedicoId = (int)_id,
                            Nombre = nombre,
                            Apellido = apellido,
                            Telefono = telefono,
                            Email = email,
                            EspecialidadId = espec.EspecialidadId,
                            UsuarioId = usuario.UsuarioId
                        };

                        await _medicoController.UpdateMedico(medico);

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Complpete los campos Correctamente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione una especialidad", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
