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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            this.locacaoTableAdapter.CustomQueryComDs(this.bibliotecaFinalSpaceDataSet.Locacao, true);
        }



        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmLocacaoAdicionar locacaoAdicionar = new frmLocacaoAdicionar();
            locacaoAdicionar.ShowDialog();

            if (locacaoAdicionar.LocacaoModel != null)
            {
                this.locacaoTableAdapter.Insert(
                locacaoAdicionar.LocacaoModel.Livro,
                locacaoAdicionar.LocacaoModel.Usuario,
                locacaoAdicionar.LocacaoModel.Tipo,
                locacaoAdicionar.LocacaoModel.DataDev,
                locacaoAdicionar.LocacaoModel.Ativo,
                locacaoAdicionar.LocacaoModel.UsuInc,
                locacaoAdicionar.LocacaoModel.UsuAlt,
                locacaoAdicionar.LocacaoModel.DatInc,
                locacaoAdicionar.LocacaoModel.DatAlt
                );

                MessageBox.Show("Registro adicionado com sucesso!", "Adicionar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizaGrid();
            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                 as MVCProject.BibliotecaFinalSpaceDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.AlteraStatusComId(false, locSelect.Id);
                        
                    }
                    break;
            }

            AtualizaGrid();
        }

        private void BtnInativos_Click(object sender, EventArgs e)
        {
            frmLocacaoInativos locacaoInativos = new frmLocacaoInativos();
            locacaoInativos.ShowDialog();

            AtualizaGrid();
        }
    }
}
