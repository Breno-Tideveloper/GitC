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
    public partial class frmLocacaoInativos : Form
    {
        public frmLocacaoInativos()
        {
            InitializeComponent();
        }

        private void FrmLocacaoInativos_Load(object sender, EventArgs e)
        {

            AtualizaGrid();

        }

        public void AtualizaGrid ()
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.CustomQueryComDs(this.bibliotecaFinalSpaceDataSet.Locacao, false);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                    as MVCProject.BibliotecaFinalSpaceDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.AlteraStatusComId(true, locSelect.Id);                        
                    }
                    break;
            }

            AtualizaGrid();
        }
    }
}
