using ConsultorioApp.Controllers;


/*
 
 VERIFICAR SI SE PUEDEN MOSTRAR SOLO LOS PACIENTES Y CITAS QUE TENGA CADA MEDICO,
Y NO TODOS LOS PACIENTES Y CITAS A CADA MEDICO.
 
 */
namespace ConsultorioApp.Views
{
    public partial class FrmLogin : Form
    {
        private LoginUserController _loginController;
        private MedicosController _medicosController;
        public FrmLogin()
        {
            InitializeComponent();
            _loginController = new LoginUserController();
            _medicosController = new MedicosController();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtbNombreUsuario.Text;
            string password = txtbPassword.Text;

            var user = await _loginController.AuthenticateUser(usuario, password);

            if (user != null)
            {

                if (user.Rol == "Administrador")
                {
                    var frmAdmin = new FrmAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
                else if(user.Rol == "Medico")
                {
                    var medico = await _medicosController.GetMedicoByUsuarioId(user.UsuarioId);

                    var frm = new FrmAdminMedicos(medico);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol de usuario no reconocido.");
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
