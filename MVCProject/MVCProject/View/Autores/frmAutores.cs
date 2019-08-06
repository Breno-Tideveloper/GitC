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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        public void AtualizaGrid()
        {
            this.autoresTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Autores);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAutoresAdicionar autoresAdicionar = new frmAutoresAdicionar();
            autoresAdicionar.ShowDialog();

            if (autoresAdicionar.ModelAutores != null)
            {
                this.autoresTableAdapter.Insert(
               autoresAdicionar.ModelAutores.Nome,
               autoresAdicionar.ModelAutores.Descricao
               );

                AtualizaGrid();

                MessageBox.Show("Autor adicionado com sucesso!",
                    "Adicionar Autor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                 as MVCProject.BibliotecaFinalSpaceDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmAutoresEditar autoresEditar = new frmAutoresEditar();
                        autoresEditar.AutoresRow = autorSelec;
                        autoresEditar.ShowDialog();

                        if (autoresEditar.ModelAutores != null)
                        {
                            this.autoresTableAdapter.CustomUpdateQuery(
                                autoresEditar.ModelAutores.Nome,
                                autoresEditar.ModelAutores.Descricao,
                                autoresEditar.AutoresRow.Id);

                            AtualizaGrid();

                            MessageBox.Show("Autor editado com sucesso!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
            }
        }
    }
}
