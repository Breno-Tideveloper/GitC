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
    public partial class frmAutoresEditar : Form
    {
        public MVCProject.BibliotecaFinalSpaceDataSet.AutoresRow AutoresRow;
        public Model.Autores ModelAutores;

        public frmAutoresEditar()
        {
            InitializeComponent();
        }

        private void FrmAutoresEditar_Load(object sender, EventArgs e)
        {
            tbxNome.Text = AutoresRow.Nome;
            tbxDesc.Text = AutoresRow.Descricao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelAutores = new Model.Autores {
                Nome = tbxNome.Text,
                Descricao = tbxDesc.Text
            };

            this.Close();
        }

        private void TbxNome_Leave(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                MessageBox.Show("Necessário informar um NOME!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNome.Focus();
            }
        }

        private void TbxDesc_Leave(object sender, EventArgs e)
        {
            if (tbxDesc.Text == "")
            {
                MessageBox.Show("Necessário informar uma DESCRIÇÃO!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxDesc.Focus();
            }
        }
    }
}
