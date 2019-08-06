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
    public partial class frmLivrosEditar : Form
    {
        public frmLivrosEditar()
        {
            InitializeComponent();
        }

        public MVCProject.BibliotecaFinalSpaceDataSet.LivrosRow LivrosRow;
        public MVCProject.BibliotecaFinalSpaceDataSet.LivroAutorRow LivroAutorRow;

        private void FrmLivrosEditar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.LivroAutor'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();

            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Generos);
            
          

            tbxTitulo.Text = LivrosRow.Titulo.ToString();
            tbxRegistro.Text = LivrosRow.Registro.ToString();
            tbxIsbn.Text = LivrosRow.Isbn.ToString();
            cbxGenero.SelectedItem = LivrosRow.Genero;
            cbxEditora.SelectedItem = LivrosRow.Genero;
            rtbxSinopse.Text = LivrosRow.Sinopse;
            rtbxObs.Text = LivrosRow.Observacoes;                                  
        }

        public void AtualizaGrid ()
        {
            this.livroAutorTableAdapter.AutoresLivroAutor(this.bibliotecaFinalSpaceDataSet.LivroAutor, LivrosRow.Id);
        }

        private void TbxTitulo_Leave(object sender, EventArgs e)
        {
            if (tbxTitulo.Text == "")
            {
                MessageBox.Show("Necessário informar o TITULO!", "Editar Livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxTitulo.Focus();
            }
        }

   

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.BibliotecaFinalSpaceDataSet.LivroAutorRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livroAutorTableAdapter.CustomDeleteQuery(autorSelec.Autor, LivrosRow.Id);

                        this.livroAutorTableAdapter.AutoresLivroAutor(this.bibliotecaFinalSpaceDataSet.LivroAutor, LivrosRow.Id);
                    }
                    break;
            }
        }

        public Model.Livros LivrosModel;
        public List<Model.Autores> AutoresList = new List<Model.Autores>();
        

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            frmLivrosAdicionarAutores adicionarAutores = new frmLivrosAdicionarAutores();
            adicionarAutores.ShowDialog();

            if (adicionarAutores.AutorObj != null)
            {
                AutoresList.Add(adicionarAutores.AutorObj);

                this.livroAutorTableAdapter.Insert(LivrosRow.Id, adicionarAutores.AutorObj.Id);

                AtualizaGrid();                
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LivrosModel = new Model.Livros
            {
                NrRegistro = LivrosRow.Id,
                Titulo = tbxTitulo.Text,
                Isbn = tbxIsbn.Text,
                Genero = (int)cbxGenero.SelectedValue,
                Editora = (int)cbxEditora.SelectedValue,
                Sinopse = rtbxSinopse.Text,
                Obs = rtbxObs.Text
            };

            this.Close();
        }
    }
}
