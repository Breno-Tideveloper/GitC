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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            this.editorasTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Editoras);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmEditorasAdicionar editorasAdicionar = new frmEditorasAdicionar();
            editorasAdicionar.ShowDialog();

            if (editorasAdicionar.ModelEditoras != null)
            {
                this.editorasTableAdapter.Insert(
                    editorasAdicionar.ModelEditoras.Nome,
                    editorasAdicionar.ModelEditoras.Descricao);

                AtualizaGrid();

                MessageBox.Show("Editora adicionada com sucesso!", "Adicionar Editora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                 as MVCProject.BibliotecaFinalSpaceDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditorasEditar editorasEditar = new frmEditorasEditar();
                        editorasEditar.EditorasRow = editoraSelec;
                        editorasEditar.ShowDialog();

                        if (editorasEditar.ModelEditoras != null)
                        {
                            this.editorasTableAdapter.CustomUpdateQuery(
                                editorasEditar.ModelEditoras.Nome,
                                editorasEditar.ModelEditoras.Descricao,
                                editorasEditar.ModelEditoras.Id
                                );

                            AtualizaGrid();

                            MessageBox.Show("Editora editada com sucesso!", "Editar Editora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
            }
        }
    }
}
