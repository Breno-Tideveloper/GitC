using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Livros
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.LivroAutor'. Você pode movê-la ou removê-la conforme necessário.
            this.livroAutorTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.LivroAutor);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            this.livrosTableAdapter.CustomQUeryComDs(this.bibliotecaFinalSpaceDataSet.Livros, true);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmLivrosAdicionar livrosAdicionar = new frmLivrosAdicionar();
            livrosAdicionar.ShowDialog();

            if (livrosAdicionar.LivrosModel != null)
            {
             this.livrosTableAdapter.Insert(
                    livrosAdicionar.LivrosModel.NrRegistro,
                    livrosAdicionar.LivrosModel.Titulo,
                    livrosAdicionar.LivrosModel.Isbn,
                    livrosAdicionar.LivrosModel.Genero,
                    livrosAdicionar.LivrosModel.Editora,
                    livrosAdicionar.LivrosModel.Sinopse,
                    livrosAdicionar.LivrosModel.Obs,
                    livrosAdicionar.LivrosModel.Ativo,
                    livrosAdicionar.LivrosModel.UsuInc,
                    livrosAdicionar.LivrosModel.UsuAlt,
                    livrosAdicionar.LivrosModel.DatInc,
                    livrosAdicionar.LivrosModel.DatAlt
                    );

                int idLivro = (int)this.livrosTableAdapter.MaxIdLivrosQuery();              


                foreach (var item in livrosAdicionar.AutoresList)
                {
                    this.livroAutorTableAdapter.Insert(idLivro, item.Id);                        
                }

                AtualizaGrid();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                    as MVCProject.BibliotecaFinalSpaceDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    frmLivrosEditar livrosEditar = new frmLivrosEditar();
                    livrosEditar.LivrosRow = livroSelec;
                    livrosEditar.ShowDialog();

                    if (livrosEditar.LivrosModel != null)
                    {
                        this.livrosTableAdapter.CustomUpdateQuery(
                            livrosEditar.LivrosModel.NrRegistro,
                            livrosEditar.LivrosModel.Titulo,
                            livrosEditar.LivrosModel.Isbn,
                            livrosEditar.LivrosModel.Genero,
                            livrosEditar.LivrosModel.Editora,
                            livrosEditar.LivrosModel.Sinopse,
                            livrosEditar.LivrosModel.Obs,
                            livrosEditar.LivrosModel.UsuAlt,
                            livrosEditar.LivrosModel.DatAlt,
                            livroSelec.Id
                            );

                        MessageBox.Show("Livro editado com sucesso!", "Editar Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    break;
                case 1:
                    {
                        this.livrosTableAdapter.AlteraStatusQuery(false, livroSelec.Id);
                    }
                    break;
            }
            AtualizaGrid();
        }

        private void BtnInativos_Click(object sender, EventArgs e)
        {
            frmLivrosInativos livrosInativos = new frmLivrosInativos();
            livrosInativos.ShowDialog();

            AtualizaGrid();
        }
    }
}
