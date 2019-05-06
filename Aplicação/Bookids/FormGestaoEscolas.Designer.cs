namespace Bookids
{
    partial class FormGestaoEscolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestaoEscolas));
            this.panelBarraFerramentas = new System.Windows.Forms.Panel();
            this.pictureBoxSetaVoltar = new System.Windows.Forms.PictureBox();
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pbLogoBarraFerramentas = new System.Windows.Forms.PictureBox();
            this.panelGestaoEscolas2 = new System.Windows.Forms.Panel();
            this.panelGestaoEscolas = new System.Windows.Forms.Panel();
            this.txtLocalidadeEscola = new System.Windows.Forms.TextBox();
            this.lblLocalidadeEscola = new System.Windows.Forms.Label();
            this.txtCodPostalEscola = new System.Windows.Forms.MaskedTextBox();
            this.lblCodPostalEscola = new System.Windows.Forms.Label();
            this.txtMailEscola = new System.Windows.Forms.TextBox();
            this.lblMailEscola = new System.Windows.Forms.Label();
            this.txtTelefoneEscola = new System.Windows.Forms.TextBox();
            this.txtMoradaEscola = new System.Windows.Forms.TextBox();
            this.tabelaEscolas = new System.Windows.Forms.DataGridView();
            this.idEscolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolasSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBookidsDataSet2 = new Bookids.bdBookidsDataSet2();
            this.lblTelefoneEscola = new System.Windows.Forms.Label();
            this.lblMoradaEscola = new System.Windows.Forms.Label();
            this.txtNomeEscola = new System.Windows.Forms.TextBox();
            this.lblNomeEscola = new System.Windows.Forms.Label();
            this.btnAlterarEscola = new System.Windows.Forms.Button();
            this.btnInserirEscola = new System.Windows.Forms.Button();
            this.btnEliminarEscola = new System.Windows.Forms.Button();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.lblDataHora = new System.Windows.Forms.Label();
            this.escolasSetTableAdapter = new Bookids.bdBookidsDataSet2TableAdapters.EscolasSetTableAdapter();
            this.panelBarraFerramentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).BeginInit();
            this.panelGestaoEscolas2.SuspendLayout();
            this.panelGestaoEscolas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEscolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraFerramentas
            // 
            this.panelBarraFerramentas.BackColor = System.Drawing.Color.Silver;
            this.panelBarraFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraFerramentas.Controls.Add(this.pictureBoxSetaVoltar);
            this.panelBarraFerramentas.Controls.Add(this.btnSairMenu);
            this.panelBarraFerramentas.Controls.Add(this.btnAjuda);
            this.panelBarraFerramentas.Controls.Add(this.pbLogoBarraFerramentas);
            this.panelBarraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.panelBarraFerramentas.Name = "panelBarraFerramentas";
            this.panelBarraFerramentas.Size = new System.Drawing.Size(662, 38);
            this.panelBarraFerramentas.TabIndex = 1;
            // 
            // pictureBoxSetaVoltar
            // 
            this.pictureBoxSetaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSetaVoltar.BackgroundImage")));
            this.pictureBoxSetaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSetaVoltar.Location = new System.Drawing.Point(8, 0);
            this.pictureBoxSetaVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSetaVoltar.Name = "pictureBoxSetaVoltar";
            this.pictureBoxSetaVoltar.Size = new System.Drawing.Size(32, 37);
            this.pictureBoxSetaVoltar.TabIndex = 14;
            this.pictureBoxSetaVoltar.TabStop = false;
            this.pictureBoxSetaVoltar.Click += new System.EventHandler(this.pictureBoxSetaVoltar_Click);
            // 
            // btnSairMenu
            // 
            this.btnSairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairMenu.Location = new System.Drawing.Point(587, 6);
            this.btnSairMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSairMenu.Name = "btnSairMenu";
            this.btnSairMenu.Size = new System.Drawing.Size(65, 26);
            this.btnSairMenu.TabIndex = 13;
            this.btnSairMenu.Text = "Sair";
            this.btnSairMenu.UseVisualStyleBackColor = true;
            this.btnSairMenu.Click += new System.EventHandler(this.btnSairMenu_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(518, 6);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(65, 26);
            this.btnAjuda.TabIndex = 12;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // pbLogoBarraFerramentas
            // 
            this.pbLogoBarraFerramentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogoBarraFerramentas.BackgroundImage")));
            this.pbLogoBarraFerramentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoBarraFerramentas.Location = new System.Drawing.Point(280, 0);
            this.pbLogoBarraFerramentas.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoBarraFerramentas.Name = "pbLogoBarraFerramentas";
            this.pbLogoBarraFerramentas.Size = new System.Drawing.Size(101, 37);
            this.pbLogoBarraFerramentas.TabIndex = 7;
            this.pbLogoBarraFerramentas.TabStop = false;
            // 
            // panelGestaoEscolas2
            // 
            this.panelGestaoEscolas2.BackColor = System.Drawing.Color.Silver;
            this.panelGestaoEscolas2.Controls.Add(this.panelGestaoEscolas);
            this.panelGestaoEscolas2.Controls.Add(this.btnAlterarEscola);
            this.panelGestaoEscolas2.Controls.Add(this.btnInserirEscola);
            this.panelGestaoEscolas2.Controls.Add(this.btnEliminarEscola);
            this.panelGestaoEscolas2.Location = new System.Drawing.Point(9, 43);
            this.panelGestaoEscolas2.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoEscolas2.Name = "panelGestaoEscolas2";
            this.panelGestaoEscolas2.Size = new System.Drawing.Size(644, 398);
            this.panelGestaoEscolas2.TabIndex = 15;
            // 
            // panelGestaoEscolas
            // 
            this.panelGestaoEscolas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGestaoEscolas.Controls.Add(this.txtLocalidadeEscola);
            this.panelGestaoEscolas.Controls.Add(this.lblLocalidadeEscola);
            this.panelGestaoEscolas.Controls.Add(this.txtCodPostalEscola);
            this.panelGestaoEscolas.Controls.Add(this.lblCodPostalEscola);
            this.panelGestaoEscolas.Controls.Add(this.txtMailEscola);
            this.panelGestaoEscolas.Controls.Add(this.lblMailEscola);
            this.panelGestaoEscolas.Controls.Add(this.txtTelefoneEscola);
            this.panelGestaoEscolas.Controls.Add(this.txtMoradaEscola);
            this.panelGestaoEscolas.Controls.Add(this.tabelaEscolas);
            this.panelGestaoEscolas.Controls.Add(this.lblTelefoneEscola);
            this.panelGestaoEscolas.Controls.Add(this.lblMoradaEscola);
            this.panelGestaoEscolas.Controls.Add(this.txtNomeEscola);
            this.panelGestaoEscolas.Controls.Add(this.lblNomeEscola);
            this.panelGestaoEscolas.Location = new System.Drawing.Point(3, 3);
            this.panelGestaoEscolas.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoEscolas.Name = "panelGestaoEscolas";
            this.panelGestaoEscolas.Size = new System.Drawing.Size(639, 347);
            this.panelGestaoEscolas.TabIndex = 6;
            // 
            // txtLocalidadeEscola
            // 
            this.txtLocalidadeEscola.Location = new System.Drawing.Point(242, 78);
            this.txtLocalidadeEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidadeEscola.Name = "txtLocalidadeEscola";
            this.txtLocalidadeEscola.Size = new System.Drawing.Size(377, 20);
            this.txtLocalidadeEscola.TabIndex = 19;
            // 
            // lblLocalidadeEscola
            // 
            this.lblLocalidadeEscola.AutoSize = true;
            this.lblLocalidadeEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLocalidadeEscola.Location = new System.Drawing.Point(165, 81);
            this.lblLocalidadeEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidadeEscola.Name = "lblLocalidadeEscola";
            this.lblLocalidadeEscola.Size = new System.Drawing.Size(73, 13);
            this.lblLocalidadeEscola.TabIndex = 18;
            this.lblLocalidadeEscola.Text = "Localidade:";
            // 
            // txtCodPostalEscola
            // 
            this.txtCodPostalEscola.Location = new System.Drawing.Point(105, 78);
            this.txtCodPostalEscola.Mask = "0000-999";
            this.txtCodPostalEscola.Name = "txtCodPostalEscola";
            this.txtCodPostalEscola.Size = new System.Drawing.Size(46, 20);
            this.txtCodPostalEscola.TabIndex = 17;
            // 
            // lblCodPostalEscola
            // 
            this.lblCodPostalEscola.AutoSize = true;
            this.lblCodPostalEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodPostalEscola.Location = new System.Drawing.Point(11, 81);
            this.lblCodPostalEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodPostalEscola.Name = "lblCodPostalEscola";
            this.lblCodPostalEscola.Size = new System.Drawing.Size(89, 13);
            this.lblCodPostalEscola.TabIndex = 15;
            this.lblCodPostalEscola.Text = "Código Postal:";
            // 
            // txtMailEscola
            // 
            this.txtMailEscola.Location = new System.Drawing.Point(295, 21);
            this.txtMailEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtMailEscola.Name = "txtMailEscola";
            this.txtMailEscola.Size = new System.Drawing.Size(324, 20);
            this.txtMailEscola.TabIndex = 14;
            // 
            // lblMailEscola
            // 
            this.lblMailEscola.AutoSize = true;
            this.lblMailEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMailEscola.Location = new System.Drawing.Point(257, 24);
            this.lblMailEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailEscola.Name = "lblMailEscola";
            this.lblMailEscola.Size = new System.Drawing.Size(34, 13);
            this.lblMailEscola.TabIndex = 13;
            this.lblMailEscola.Text = "Mail:";
            // 
            // txtTelefoneEscola
            // 
            this.txtTelefoneEscola.Location = new System.Drawing.Point(76, 51);
            this.txtTelefoneEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefoneEscola.MaxLength = 9;
            this.txtTelefoneEscola.Name = "txtTelefoneEscola";
            this.txtTelefoneEscola.Size = new System.Drawing.Size(177, 20);
            this.txtTelefoneEscola.TabIndex = 12;
            this.txtTelefoneEscola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneEscola_KeyPress);
            // 
            // txtMoradaEscola
            // 
            this.txtMoradaEscola.Location = new System.Drawing.Point(314, 51);
            this.txtMoradaEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoradaEscola.Name = "txtMoradaEscola";
            this.txtMoradaEscola.Size = new System.Drawing.Size(305, 20);
            this.txtMoradaEscola.TabIndex = 11;
            // 
            // tabelaEscolas
            // 
            this.tabelaEscolas.AllowUserToAddRows = false;
            this.tabelaEscolas.AllowUserToDeleteRows = false;
            this.tabelaEscolas.AutoGenerateColumns = false;
            this.tabelaEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEscolas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEscolaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn});
            this.tabelaEscolas.DataSource = this.escolasSetBindingSource;
            this.tabelaEscolas.Location = new System.Drawing.Point(2, 120);
            this.tabelaEscolas.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaEscolas.Name = "tabelaEscolas";
            this.tabelaEscolas.ReadOnly = true;
            this.tabelaEscolas.RowTemplate.Height = 24;
            this.tabelaEscolas.Size = new System.Drawing.Size(635, 225);
            this.tabelaEscolas.TabIndex = 8;
            this.tabelaEscolas.Click += new System.EventHandler(this.tabelaEscolas_Click);
            // 
            // idEscolaDataGridViewTextBoxColumn
            // 
            this.idEscolaDataGridViewTextBoxColumn.DataPropertyName = "IdEscola";
            this.idEscolaDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idEscolaDataGridViewTextBoxColumn.Name = "idEscolaDataGridViewTextBoxColumn";
            this.idEscolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEscolaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "Código Postal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escolasSetBindingSource
            // 
            this.escolasSetBindingSource.DataMember = "EscolasSet";
            this.escolasSetBindingSource.DataSource = this.bdBookidsDataSet2;
            // 
            // bdBookidsDataSet2
            // 
            this.bdBookidsDataSet2.DataSetName = "bdBookidsDataSet2";
            this.bdBookidsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTelefoneEscola
            // 
            this.lblTelefoneEscola.AutoSize = true;
            this.lblTelefoneEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefoneEscola.Location = new System.Drawing.Point(11, 54);
            this.lblTelefoneEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneEscola.Name = "lblTelefoneEscola";
            this.lblTelefoneEscola.Size = new System.Drawing.Size(61, 13);
            this.lblTelefoneEscola.TabIndex = 4;
            this.lblTelefoneEscola.Text = "Telefone:";
            // 
            // lblMoradaEscola
            // 
            this.lblMoradaEscola.AutoSize = true;
            this.lblMoradaEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMoradaEscola.Location = new System.Drawing.Point(257, 54);
            this.lblMoradaEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoradaEscola.Name = "lblMoradaEscola";
            this.lblMoradaEscola.Size = new System.Drawing.Size(53, 13);
            this.lblMoradaEscola.TabIndex = 2;
            this.lblMoradaEscola.Text = "Morada:";
            // 
            // txtNomeEscola
            // 
            this.txtNomeEscola.Location = new System.Drawing.Point(58, 21);
            this.txtNomeEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEscola.Name = "txtNomeEscola";
            this.txtNomeEscola.Size = new System.Drawing.Size(195, 20);
            this.txtNomeEscola.TabIndex = 1;
            // 
            // lblNomeEscola
            // 
            this.lblNomeEscola.AutoSize = true;
            this.lblNomeEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeEscola.Location = new System.Drawing.Point(11, 24);
            this.lblNomeEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEscola.Name = "lblNomeEscola";
            this.lblNomeEscola.Size = new System.Drawing.Size(43, 13);
            this.lblNomeEscola.TabIndex = 0;
            this.lblNomeEscola.Text = "Nome:";
            // 
            // btnAlterarEscola
            // 
            this.btnAlterarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEscola.Location = new System.Drawing.Point(490, 354);
            this.btnAlterarEscola.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarEscola.Name = "btnAlterarEscola";
            this.btnAlterarEscola.Size = new System.Drawing.Size(74, 33);
            this.btnAlterarEscola.TabIndex = 5;
            this.btnAlterarEscola.Text = "Alterar";
            this.btnAlterarEscola.UseVisualStyleBackColor = true;
            this.btnAlterarEscola.Click += new System.EventHandler(this.btnAlterarEscola_Click);
            // 
            // btnInserirEscola
            // 
            this.btnInserirEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEscola.Location = new System.Drawing.Point(412, 354);
            this.btnInserirEscola.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirEscola.Name = "btnInserirEscola";
            this.btnInserirEscola.Size = new System.Drawing.Size(74, 33);
            this.btnInserirEscola.TabIndex = 2;
            this.btnInserirEscola.Text = "Inserir";
            this.btnInserirEscola.UseVisualStyleBackColor = true;
            this.btnInserirEscola.Click += new System.EventHandler(this.btnInserirEscola_Click);
            // 
            // btnEliminarEscola
            // 
            this.btnEliminarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEscola.Location = new System.Drawing.Point(568, 354);
            this.btnEliminarEscola.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEscola.Name = "btnEliminarEscola";
            this.btnEliminarEscola.Size = new System.Drawing.Size(74, 33);
            this.btnEliminarEscola.TabIndex = 1;
            this.btnEliminarEscola.Text = "Eliminar";
            this.btnEliminarEscola.UseVisualStyleBackColor = true;
            this.btnEliminarEscola.Click += new System.EventHandler(this.btnEliminarEscola_Click);
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDataHora.Location = new System.Drawing.Point(506, 443);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(41, 13);
            this.lblDataHora.TabIndex = 16;
            this.lblDataHora.Text = "label1";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // escolasSetTableAdapter
            // 
            this.escolasSetTableAdapter.ClearBeforeFill = true;
            // 
            // FormGestaoEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 465);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.panelGestaoEscolas2);
            this.Controls.Add(this.panelBarraFerramentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoEscolas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Escolas";
            this.Load += new System.EventHandler(this.FormGestaoEscolas_Load);
            this.panelBarraFerramentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).EndInit();
            this.panelGestaoEscolas2.ResumeLayout(false);
            this.panelGestaoEscolas.ResumeLayout(false);
            this.panelGestaoEscolas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEscolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraFerramentas;
        private System.Windows.Forms.PictureBox pictureBoxSetaVoltar;
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pbLogoBarraFerramentas;
        private System.Windows.Forms.Panel panelGestaoEscolas2;
        private System.Windows.Forms.Panel panelGestaoEscolas;
        private System.Windows.Forms.DataGridView tabelaEscolas;
        private System.Windows.Forms.Label lblTelefoneEscola;
        private System.Windows.Forms.Label lblMoradaEscola;
        private System.Windows.Forms.TextBox txtNomeEscola;
        private System.Windows.Forms.Label lblNomeEscola;
        private System.Windows.Forms.Button btnAlterarEscola;
        private System.Windows.Forms.Button btnInserirEscola;
        private System.Windows.Forms.Button btnEliminarEscola;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.TextBox txtMoradaEscola;
        private System.Windows.Forms.TextBox txtTelefoneEscola;
        private System.Windows.Forms.TextBox txtMailEscola;
        private System.Windows.Forms.Label lblMailEscola;
        private System.Windows.Forms.Label lblCodPostalEscola;
        private System.Windows.Forms.MaskedTextBox txtCodPostalEscola;
        private System.Windows.Forms.Label lblLocalidadeEscola;
        private System.Windows.Forms.TextBox txtLocalidadeEscola;
        private bdBookidsDataSet2 bdBookidsDataSet2;
        private System.Windows.Forms.BindingSource escolasSetBindingSource;
        private bdBookidsDataSet2TableAdapters.EscolasSetTableAdapter escolasSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
    }
}