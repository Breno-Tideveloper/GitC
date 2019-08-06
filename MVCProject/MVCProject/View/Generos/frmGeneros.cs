using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Generos
{
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmGenerosAdicionar generosAdicionar = new frmGenerosAdicionar();
            generosAdicionar.ShowDialog();

            if (generosAdicionar.ModelGeneros != null)
            {
                this.generosTableAdapter.Insert(
                    generosAdicionar.ModelGeneros.Genero,
                    generosAdicionar.ModelGeneros.Descricao
                    );

                AtualizaGrid();

                MessageBox.Show("Gênero adicionado com sucesso!", "Adicionar Gênero", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void AtualizaGrid ()
        {
            this.generosTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                    as MVCProject.BibliotecaFinalSpaceDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmGenerosEditar generosEditar = new frmGenerosEditar();
                        generosEditar.GenerosRow = generoSelec;
                        generosEditar.ShowDialog();

                        if (generosEditar.ModelGeneros != null)
                        {
                            this.generosTableAdapter.CustomUpdateQuery(
                            generosEditar.ModelGeneros.Genero,
                            generosEditar.ModelGeneros.Descricao,
                            generosEditar.ModelGeneros.Id
                            );

                            AtualizaGrid();

                            MessageBox.Show("Gênero editado com sucesso!", "Editar Gênero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    break;
            }
        }
    }
}
