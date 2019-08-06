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
    public partial class frmLivrosAdicionar : Form
    {
        public frmLivrosAdicionar()
        {
            InitializeComponent();
        }

        private void TbxTitulo_Leave(object sender, EventArgs e)
        {
            if (tbxTitulo.Text == "")
            {
                MessageBox.Show("Necessário informar o TITULO!", "Editar Livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxTitulo.Focus();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbxRegistro.Text, out int cdRegistro);
            
                LivrosModel = new Model.Livros {
                    NrRegistro = cdRegistro,
                    Titulo = tbxTitulo.Text,
                    Isbn = tbxIsbn.Text,
                    Genero = (int) cbxGenero.SelectedValue,
                    Editora = (int) cbxEditora.SelectedValue,
                    Sinopse = rtbxSinopse.Text,
                    Obs = rtbxObs.Text
                };

            this.Close();

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

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = AutoresList;
            }                      
        }

        private void FrmLivrosAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Generos);

        }
    }
}
