using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Usuarios
{
    public partial class frmUsuariosEditar : Form
    {
        public frmUsuariosEditar()
        {
            InitializeComponent();
        }

        public MVCProject.BibliotecaFinalSpaceDataSet.UsuariosRow UsuariosRow;
        public Model.Usuarios ModelUsuarios;

        private void FrmUsuariosEditar_Load(object sender, EventArgs e)
        {
            tbxNome.Text = UsuariosRow.Nome;
            tbxLogin.Text = UsuariosRow.Login;
            tbxSenha.Text = UsuariosRow.Senha;
            tbxEmail.Text = UsuariosRow.Email;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelUsuarios = new Model.Usuarios()
            {
                Id = UsuariosRow.Id,
                Nome = tbxNome.Text,
                Login = tbxLogin.Text,
                Senha = tbxSenha.Text,
                Email = tbxEmail.Text                
            };

            this.Close();
        }

        private void TbxNome_Leave(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                MostraMensagemErro("nome", "Adicionar Usuário");
                tbxNome.Focus();
            }
        }

        private void TbxLogin_Leave(object sender, EventArgs e)
        {
            if (tbxLogin.Text == "")
            {
                MostraMensagemErro("login", "Adicionar Usuário");
                tbxLogin.Focus();
            }
        }

        public void MostraMensagemErro(string pCampo, string pTextoCxDialogo)
        {

            MessageBox.Show($"Necessário informar {pCampo.ToUpper()}!",
                pTextoCxDialogo,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TbxSenha_Leave(object sender, EventArgs e)
        {
            if (tbxSenha.Text == "")
            {
                MostraMensagemErro("senha", "Adicionar Usuário");
                tbxSenha.Focus();
            }
        }

        private void TbxEmail_Leave(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "")
            {
                MostraMensagemErro("email", "Adicionar Usuário");
                tbxEmail.Focus();
            }
        }
    }
}
