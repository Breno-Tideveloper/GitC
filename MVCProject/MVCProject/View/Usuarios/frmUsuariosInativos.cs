using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Usuarios
{
    public partial class frmUsuariosInativos : Form
    {
        public frmUsuariosInativos()
        {
            InitializeComponent();
        }

        private void FrmUsuariosInativos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.

            AtualizaGrid();
        }

        public void AtualizaGrid ()
        {
            this.usuariosTableAdapter.CustomQueryInativos(this.bibliotecaFinalSpaceDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            var usuSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                    as MVCProject.BibliotecaFinalSpaceDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.AlteraStatusQuery(true, usuSelec.Id);
                    }
                    break;
            }

            AtualizaGrid();
        }
    }
}
