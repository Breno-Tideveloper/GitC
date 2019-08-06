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
    public partial class frmLivrosAdicionarAutores : Form
    {
        public frmLivrosAdicionarAutores()
        {
            InitializeComponent();
        }

        public Model.Autores AutorObj;

        public string NomeAutor;
        public int IdAutor;

        private void FrmLivrosAdicionarAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            //this.autoresTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Autores);
            this.autoresTableAdapter.PesquisaAutorCustomQuery(this.bibliotecaFinalSpaceDataSet.Autores,
                tbxNome.Text,
                tbxDesc.Text);
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.BibliotecaFinalSpaceDataSet.AutoresRow;

            AutorObj = new Model.Autores {
                Id = autorSelec.Id,
                Nome = autorSelec.Nome   ,
                Descricao = autorSelec.Descricao
            };

            this.Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Autores.frmAutoresAdicionar autoresAdicionar = new Autores.frmAutoresAdicionar();
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

            AtualizaGrid();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
