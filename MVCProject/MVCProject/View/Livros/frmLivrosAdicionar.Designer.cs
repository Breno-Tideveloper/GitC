namespace MVCProject.View.Livros
{
    partial class frmLivrosAdicionar
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaFinalSpaceDataSet = new MVCProject.BibliotecaFinalSpaceDataSet();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbxSinopse = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbxObs = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutores = new System.Windows.Forms.Button();
            this.generosTableAdapter = new MVCProject.BibliotecaFinalSpaceDataSetTableAdapters.GenerosTableAdapter();
            this.editorasTableAdapter = new MVCProject.BibliotecaFinalSpaceDataSetTableAdapters.EditorasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaFinalSpaceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalvar.Location = new System.Drawing.Point(445, 325);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 50);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Registro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxRegistro
            // 
            this.tbxRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxRegistro.Location = new System.Drawing.Point(120, 63);
            this.tbxRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRegistro.Name = "tbxRegistro";
            this.tbxRegistro.Size = new System.Drawing.Size(344, 23);
            this.tbxRegistro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(67, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Titulo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxTitulo.Location = new System.Drawing.Point(120, 34);
            this.tbxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(344, 23);
            this.tbxTitulo.TabIndex = 1;
            this.tbxTitulo.Leave += new System.EventHandler(this.TbxTitulo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(68, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ISBN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxIsbn.Location = new System.Drawing.Point(120, 92);
            this.tbxIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(344, 23);
            this.tbxIsbn.TabIndex = 3;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DataSource = this.generosBindingSource;
            this.cbxGenero.DisplayMember = "Tipo";
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(120, 122);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(344, 25);
            this.cbxGenero.TabIndex = 4;
            this.cbxGenero.ValueMember = "Id";
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.bibliotecaFinalSpaceDataSet;
            // 
            // bibliotecaFinalSpaceDataSet
            // 
            this.bibliotecaFinalSpaceDataSet.DataSetName = "BibliotecaFinalSpaceDataSet";
            this.bibliotecaFinalSpaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxEditora
            // 
            this.cbxEditora.DataSource = this.editorasBindingSource;
            this.cbxEditora.DisplayMember = "Nome";
            this.cbxEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(120, 151);
            this.cbxEditora.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(344, 25);
            this.cbxEditora.TabIndex = 5;
            this.cbxEditora.ValueMember = "Id";
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.bibliotecaFinalSpaceDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(55, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gênero:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(57, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Editora:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbxSinopse
            // 
            this.rtbxSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtbxSinopse.Location = new System.Drawing.Point(120, 181);
            this.rtbxSinopse.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxSinopse.Name = "rtbxSinopse";
            this.rtbxSinopse.Size = new System.Drawing.Size(344, 61);
            this.rtbxSinopse.TabIndex = 6;
            this.rtbxSinopse.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(51, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sinopse:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbxObs
            // 
            this.rtbxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtbxObs.Location = new System.Drawing.Point(120, 245);
            this.rtbxObs.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxObs.Name = "rtbxObs";
            this.rtbxObs.Size = new System.Drawing.Size(344, 61);
            this.rtbxObs.TabIndex = 7;
            this.rtbxObs.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(17, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Observações:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAutores
            // 
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAutores.Location = new System.Drawing.Point(805, 23);
            this.btnAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(117, 36);
            this.btnAutores.TabIndex = 8;
            this.btnAutores.Text = "Adicionar";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.BtnAutores_Click);
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(436, 240);
            this.dataGridView1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(483, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Autores";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLivrosAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1020, 396);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbxObs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbxSinopse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEditora);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLivrosAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Livro";
            this.Load += new System.EventHandler(this.FrmLivrosAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaFinalSpaceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbxSinopse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbxObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAutores;
        private BibliotecaFinalSpaceDataSet bibliotecaFinalSpaceDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private BibliotecaFinalSpaceDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private BibliotecaFinalSpaceDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
    }
}