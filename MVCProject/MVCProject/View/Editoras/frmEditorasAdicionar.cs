using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editoras
{
    public partial class frmEditorasAdicionar : Form
    {
        public frmEditorasAdicionar()
        {
            InitializeComponent();
        }

        public Model.Editoras ModelEditoras;

        private void TbxNome_Leave(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                MessageBox.Show("Necessário informar o NOME!", "Adicionar Editora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNome.Focus();
            }
        }

        private void TbxDesc_Leave(object sender, EventArgs e)
        {
            if (tbxDesc.Text == "")
            {
                MessageBox.Show("Necessário informar a DESCRIÇÃO!", "Adicionar Editora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxDesc.Focus();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelEditoras = new Model.Editoras {
                Nome = tbxNome.Text,
                Descricao = tbxDesc.Text
            };

            this.Close();
        }
    }
}
