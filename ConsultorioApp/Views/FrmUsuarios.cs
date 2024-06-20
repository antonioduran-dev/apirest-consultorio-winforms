using ConsultorioApp.Controllers;
using ConsultorioApp.Models;
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
    public partial class FrmUsuarios : Form
    {
        private UsuariosController _usuarioController;
        private IEnumerable<Usuario> _usuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarioController = new UsuariosController();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            GetUsuarios();
        }

        private async void GetUsuarios()
        {
            _usuarios = await _usuarioController.GetUsuarios();
            List<UsuarioModel> usuariosModel = new List<UsuarioModel>();

            if (_usuarios != null)
            {
                foreach (var usuario in _usuarios)
                {
                    // creates new MedicoModel and adds to list.
                    usuariosModel.Add(new UsuarioModel
                    {
                        UsuarioId = usuario.UsuarioId,
                        NombreUsuario = usuario.NombreUsuario,
                        Rol = usuario.Rol
                    });
                }
                // create a new data grid source with the list given.
                dgridUsuarios.DataSource = usuariosModel;
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la Información", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*
             CAMBIAR CUANDO SE AGREGEN LOS USUARIOS, PARA VOLVER AL PANLE DE USUARIO CORRESPONDIENTE
            Y SOLO PUEDA ACCEDER A LOS FORMULARIOS QUE TENGA ACCESO.
             */
            FrmAdmin frm = new FrmAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateUsuarios();
            frm.ShowDialog();
            GetUsuarios();
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                var frm = new FrmUpdateUsuarios(id);
                frm.ShowDialog();
                GetUsuarios();
            }
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _usuarioController.DeleteUsuario((int)id);
                    GetUsuarios();
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
                return int.Parse(dgridUsuarios.Rows[dgridUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
