using ConsultorioApp.Controllers;
using DB.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmUpdateUsuarios : Form
    {
        private int? _id;
        private UsuariosController _usuarioController;

        public FrmUpdateUsuarios(int? id = null)
        {
            InitializeComponent();
            _usuarioController = new UsuariosController();
            _id = id;

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateUsuarios_Load(object sender, EventArgs e)
        {

        }

        private async void LoadData()
        {
            Usuario usuario = await _usuarioController.GetUsuario((int)_id!);

            txtbNombreUsuario.Text = usuario.NombreUsuario;
            txtbPassword.Text = usuario.Clave;
            txtbRol.Text = usuario.Rol;
        }

        private async void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtbNombreUsuario.Text;
            string password = txtbPassword.Text;
            string rol = txtbRol.Text;

            if (_id == null)
            {
                if (nombreUsuario.Trim() != "" && password.Trim() != "" && rol != "")
                {
                    Usuario usuario = new Usuario()
                    {
                        NombreUsuario = nombreUsuario,
                        Clave = password,
                        Rol = rol
                    };

                    await _usuarioController.AddUsuario(usuario);

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
                if (nombreUsuario.Trim() != "" && password.Trim() != "" && rol != "")
                {
                    Usuario usuario = new Usuario()
                    {
                        UsuarioId = (int)_id,
                        NombreUsuario = nombreUsuario,
                        Clave = password,
                        Rol = rol
                    };

                    await _usuarioController.UpdateUsuario(usuario);

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
