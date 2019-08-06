using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Locacao
{
    public partial class frmLocacaoAdicionar : Form
    {
        public frmLocacaoAdicionar()
        {
            InitializeComponent();
        }

        private void FrmLocacaoAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.CustomQuery(this.bibliotecaFinalSpaceDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.CustomQuery(this.bibliotecaFinalSpaceDataSet.Livros);

            cbTipo.SelectedIndex = 0;

        }

        public Model.Locacao LocacaoModel;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int cdTipo = 0;

            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    cdTipo = 1;
                    break;
                case 1:
                    cdTipo = 2;
                    break;
            }

            LocacaoModel = new Model.Locacao {
                Livro = (int)cbLivro.SelectedValue,
                Usuario = (int)cbUsuario.SelectedValue,
                Tipo = cdTipo,
                DataDev = dtpDev.Value
            };

            this.Close();
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    lbDev.Text = "Devolução:";
                    dtpDev.Value = DateTime.Now;
                    dtpDev.Enabled = true;
                    break;
                case 1:
                    lbDev.Text = "Data:";
                    dtpDev.Value = DateTime.Now;
                    dtpDev.Enabled = false;
                    break;
            }
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.livrosTableAdapter.FillBy(this.bibliotecaFinalSpaceDataSet.Livros);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
