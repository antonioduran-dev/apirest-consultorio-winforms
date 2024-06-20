using ConsultorioApp.Views;

namespace ConsultorioApp
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FrmEspecialidades frm = new FrmEspecialidades();
            frm.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos frm = new FrmMedicos();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var frm = new FrmLogin();
            frm.Show();
            this.Close();
        }
    }
}
