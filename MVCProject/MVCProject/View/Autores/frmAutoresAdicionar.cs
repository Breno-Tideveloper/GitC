using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Autores
{
    public partial class frmAutoresAdicionar : Form
    {
        public frmAutoresAdicionar()
        {
            InitializeComponent();
        }

        private void TbxNome_Leave(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                MostraMensagemErro("nome", "Adicionar Autor");
                tbxNome.Focus();
            }
        }

        private void TbxDesc_Leave(object sender, EventArgs e)
        {
            if (tbxDesc.Text == "")
            {
                MostraMensagemErro("Descriçao" , "Adicionar Autor");
                tbxDesc.Focus();
            }
        }

        public void MostraMensagemErro(string pCampo, string pTextoCxDialogo)
        {

            MessageBox.Show($"Necessário informar {pCampo.ToUpper()}!",
                pTextoCxDialogo,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Model.Autores ModelAutores;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelAutores = new Model.Autores {
                Nome = tbxNome.Text,
                Descricao = tbxDesc.Text
            };

            this.Close();
        }
    }
}
