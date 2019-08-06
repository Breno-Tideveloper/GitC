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
    public partial class frmLivrosInativos : Form
    {
        public frmLivrosInativos()
        {
            InitializeComponent();
        }

        private void FrmLivrosInativos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            
            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            this.livrosTableAdapter.CustomQueryInativos(this.bibliotecaFinalSpaceDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                   as MVCProject.BibliotecaFinalSpaceDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.AlteraStatusQuery(true, livroSelec.Id);
                    }
                    break;
            }

            AtualizaGrid();
        }
    }
}
