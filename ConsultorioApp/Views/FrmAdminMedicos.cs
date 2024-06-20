
using DB.Models;

namespace ConsultorioApp.Views
{
    public partial class FrmAdminMedicos : Form
    {
        private Medico _medico;
        public FrmAdminMedicos(Medico medico)
        {
            InitializeComponent();
            _medico = medico;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var frm = new FrmPacientes(_medico);
            frm.Show();
            this.Hide();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var frm = new FrmCitas(_medico);
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
