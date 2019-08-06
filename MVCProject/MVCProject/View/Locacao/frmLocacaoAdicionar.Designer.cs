namespace MVCProject.View.Locacao
{
    partial class frmLocacaoAdicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbDev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaFinalSpaceDataSet = new MVCProject.BibliotecaFinalSpaceDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new MVCProject.BibliotecaFinalSpaceDataSetTableAdapters.LivrosTableAdapter();
            this.dtpDev = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.usuariosTableAdapter = new MVCProject.BibliotecaFinalSpaceDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaFinalSpaceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(225, 150);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 50);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lbDev
            // 
            this.lbDev.AutoSize = true;
            this.lbDev.Location = new System.Drawing.Point(44, 119);
            this.lbDev.Name = "lbDev";
            this.lbDev.Size = new System.Drawing.Size(79, 17);
            this.lbDev.TabIndex = 19;
            this.lbDev.Text = "Devolução:";
            this.lbDev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Livro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuário:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbLivro
            // 
            this.cbLivro.DataSource = this.livrosBindingSource1;
            this.cbLivro.DisplayMember = "Titulo";
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(132, 24);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(344, 24);
            this.cbLivro.TabIndex = 25;
            this.cbLivro.ValueMember = "Id";
            // 
            // livrosBindingSource1
            // 
            this.livrosBindingSource1.DataMember = "Livros";
            this.livrosBindingSource1.DataSource = this.bibliotecaFinalSpaceDataSet;
            // 
            // bibliotecaFinalSpaceDataSet
            // 
            this.bibliotecaFinalSpaceDataSet.DataSetName = "BibliotecaFinalSpaceDataSet";
            this.bibliotecaFinalSpaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaFinalSpaceDataSet;
            // 
            // cbUsuario
            // 
            this.cbUsuario.DataSource = this.usuariosBindingSource;
            this.cbUsuario.DisplayMember = "Nome";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(132, 54);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(344, 24);
            this.cbUsuario.TabIndex = 26;
            this.cbUsuario.ValueMember = "Id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotecaFinalSpaceDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDev
            // 
            this.dtpDev.Location = new System.Drawing.Point(132, 114);
            this.dtpDev.Name = "dtpDev";
            this.dtpDev.Size = new System.Drawing.Size(344, 22);
            this.dtpDev.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Locação",
            "Devolução"});
            this.cbTipo.Location = new System.Drawing.Point(132, 84);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(344, 24);
            this.cbTipo.TabIndex = 32;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmLocacaoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 220);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDev);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocacaoAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Locação";
            this.Load += new System.EventHandler(this.FrmLocacaoAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaFinalSpaceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.ComboBox cbUsuario;
        private BibliotecaFinalSpaceDataSet bibliotecaFinalSpaceDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BibliotecaFinalSpaceDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotecaFinalSpaceDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.BindingSource livrosBindingSource1;
    }
}