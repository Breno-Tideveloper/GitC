using MVCProject.View.Usuarios;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            AtualizaGrid();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmUsuariosAdicionar usuariosAdicionar = new frmUsuariosAdicionar();
            usuariosAdicionar.ShowDialog();

            if (usuariosAdicionar.ModelUsuarios != null)
            {
                this.usuariosTableAdapter.InsertCustomQuery(
                usuariosAdicionar.ModelUsuarios.Nome,
                usuariosAdicionar.ModelUsuarios.Login,
                usuariosAdicionar.ModelUsuarios.Senha,
                usuariosAdicionar.ModelUsuarios.Email,
                usuariosAdicionar.ModelUsuarios.Ativo,
                usuariosAdicionar.ModelUsuarios.UsuInc,
                usuariosAdicionar.ModelUsuarios.UsuAlt,
                usuariosAdicionar.ModelUsuarios.DatInc,
                usuariosAdicionar.ModelUsuarios.DatAlt);

                MessageBox.Show("Usuário adicionado com sucesso!",
                    "Adicionar Usuário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                AtualizaGrid();
            }      
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelec = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.BibliotecaFinalSpaceDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmUsuariosEditar usuariosEditar = new frmUsuariosEditar();
                        usuariosEditar.UsuariosRow = usuSelec;
                        usuariosEditar.ShowDialog();

                        if (usuariosEditar.ModelUsuarios != null)
                        {
                          this.usuariosTableAdapter.CustomQueryEditar(
                                usuariosEditar.ModelUsuarios.Nome,
                                usuariosEditar.ModelUsuarios.Login,
                                usuariosEditar.ModelUsuarios.Senha,
                                usuariosEditar.ModelUsuarios.Email,
                                usuariosEditar.ModelUsuarios.UsuAlt,
                                usuariosEditar.ModelUsuarios.DatAlt,
                                usuariosEditar.ModelUsuarios.Id
                                );

                            AtualizaGrid();
                        }
                    }
                    break;
                case 1:
                    {
                        this.usuariosTableAdapter.AlteraStatusQuery(false, usuSelec.Id);
                    }
                    break;
            }
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            this.usuariosTableAdapter.CustomQuery(this.bibliotecaFinalSpaceDataSet.Usuarios);
        }

        private void BtnInativos_Click(object sender, EventArgs e)
        {
            frmUsuariosInativos usuariosInativos = new frmUsuariosInativos();
            usuariosInativos.ShowDialog();

            AtualizaGrid();

        }
    }
    }

