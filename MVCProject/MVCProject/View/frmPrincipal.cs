using MVCProject.View.Autores;
using MVCProject.View.Editoras;
using MVCProject.View.Generos;
using MVCProject.View.Livros;
using MVCProject.View.Locacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autores = new frmAutores();
            autores.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros generos = new frmGeneros();
            generos.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras editoras = new frmEditoras();
            editoras.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao locacao = new frmLocacao();
            locacao.ShowDialog();
        }
      
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Generos);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.CustomQUeryComDs(this.bibliotecaFinalSpaceDataSet.Livros, true);
            //AtualizaGrid();

        }

        public void AtualizaGrid()
        {
            this.livrosTableAdapter.CustomQUeryComDs(
                this.bibliotecaFinalSpaceDataSet.Livros, true);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
