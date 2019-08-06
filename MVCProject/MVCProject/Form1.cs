using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public static int Usuario { get; set; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var id = this.usuariosTableAdapter.ValidaLogin(
                tbxLogin.Text, mtbSenha.Text);

            if (id == null)
            {
                MessageBox.Show("LOGIN ou SENHA inválidos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbSenha.Clear();
                tbxLogin.Focus();
            }
            else
            {
                Model.Informacao informacao = new Model.Informacao();
                Usuario = (int)id;
                //informacao.UsuAlt = id;

                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
                this.Close();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaFinalSpaceDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.bibliotecaFinalSpaceDataSet.Usuarios);

        }

    }
   
}

