namespace Bookids
{
    partial class FormGestaoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestaoClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.pbLogoBarraFerramentas = new System.Windows.Forms.PictureBox();
            this.pictureBoxSetaVoltar = new System.Windows.Forms.PictureBox();
            this.lbDataHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.panelGestaoClientes2 = new System.Windows.Forms.Panel();
            this.txtNCartaoCliente = new System.Windows.Forms.NumericUpDown();
            this.lblNCartaoCliente = new System.Windows.Forms.Label();
            this.lblValorOfertaCliente = new System.Windows.Forms.Label();
            this.txtValorOfertaCliente = new System.Windows.Forms.NumericUpDown();
            this.txtLocalidadeCliente = new System.Windows.Forms.TextBox();
            this.lblLocalidadeCliente = new System.Windows.Forms.Label();
            this.txtMoradaCliente = new System.Windows.Forms.TextBox();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.lblMailCliente = new System.Windows.Forms.Label();
            this.txtTelemovelCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.txtCodPostalCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblMoradaEscola = new System.Windows.Forms.Label();
            this.lblCodPostalCliente = new System.Windows.Forms.Label();
            this.tabelaEscolas = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBookidsDataSet3 = new Bookids.bdBookidsDataSet3();
            this.lblTelemovelCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.panelGestaoClientes = new System.Windows.Forms.Panel();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.view_3TableAdapter = new Bookids.bdBookidsDataSet3TableAdapters.View_3TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).BeginInit();
            this.panelGestaoClientes2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCartaoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorOfertaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEscolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet3)).BeginInit();
            this.panelGestaoClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSairMenu);
            this.panel1.Controls.Add(this.pbLogoBarraFerramentas);
            this.panel1.Controls.Add(this.pictureBoxSetaVoltar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(518, 6);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(65, 26);
            this.btnAjuda.TabIndex = 11;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnSairMenu
            // 
            this.btnSairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairMenu.Location = new System.Drawing.Point(587, 6);
            this.btnSairMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSairMenu.Name = "btnSairMenu";
            this.btnSairMenu.Size = new System.Drawing.Size(65, 26);
            this.btnSairMenu.TabIndex = 10;
            this.btnSairMenu.Text = "Sair";
            this.btnSairMenu.UseVisualStyleBackColor = true;
            this.btnSairMenu.Click += new System.EventHandler(this.btnSairMenu_Click);
            // 
            // pbLogoBarraFerramentas
            // 
            this.pbLogoBarraFerramentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogoBarraFerramentas.BackgroundImage")));
            this.pbLogoBarraFerramentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoBarraFerramentas.Location = new System.Drawing.Point(281, 0);
            this.pbLogoBarraFerramentas.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoBarraFerramentas.Name = "pbLogoBarraFerramentas";
            this.pbLogoBarraFerramentas.Size = new System.Drawing.Size(101, 37);
            this.pbLogoBarraFerramentas.TabIndex = 7;
            this.pbLogoBarraFerramentas.TabStop = false;
            // 
            // pictureBoxSetaVoltar
            // 
            this.pictureBoxSetaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSetaVoltar.BackgroundImage")));
            this.pictureBoxSetaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSetaVoltar.Location = new System.Drawing.Point(8, 0);
            this.pictureBoxSetaVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSetaVoltar.Name = "pictureBoxSetaVoltar";
            this.pictureBoxSetaVoltar.Size = new System.Drawing.Size(32, 37);
            this.pictureBoxSetaVoltar.TabIndex = 6;
            this.pictureBoxSetaVoltar.TabStop = false;
            this.pictureBoxSetaVoltar.Click += new System.EventHandler(this.pictureBoxSetaVoltar_Click);
            // 
            // lbDataHora
            // 
            this.lbDataHora.AutoSize = true;
            this.lbDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbDataHora.Location = new System.Drawing.Point(502, 428);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(41, 13);
            this.lbDataHora.TabIndex = 1;
            this.lbDataHora.Text = "label1";
            this.lbDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // panelGestaoClientes2
            // 
            this.panelGestaoClientes2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGestaoClientes2.Controls.Add(this.txtNCartaoCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblNCartaoCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblValorOfertaCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtValorOfertaCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtLocalidadeCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblLocalidadeCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtMoradaCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtMailCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblMailCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtTelemovelCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtTelefoneCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtCodPostalCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblMoradaEscola);
            this.panelGestaoClientes2.Controls.Add(this.lblCodPostalCliente);
            this.panelGestaoClientes2.Controls.Add(this.tabelaEscolas);
            this.panelGestaoClientes2.Controls.Add(this.lblTelemovelCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblTelefoneCliente);
            this.panelGestaoClientes2.Controls.Add(this.txtNomeCliente);
            this.panelGestaoClientes2.Controls.Add(this.lblNomeCliente);
            this.panelGestaoClientes2.Location = new System.Drawing.Point(3, 3);
            this.panelGestaoClientes2.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoClientes2.Name = "panelGestaoClientes2";
            this.panelGestaoClientes2.Size = new System.Drawing.Size(639, 347);
            this.panelGestaoClientes2.TabIndex = 6;
            // 
            // txtNCartaoCliente
            // 
            this.txtNCartaoCliente.Location = new System.Drawing.Point(514, 109);
            this.txtNCartaoCliente.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtNCartaoCliente.Name = "txtNCartaoCliente";
            this.txtNCartaoCliente.Size = new System.Drawing.Size(116, 20);
            this.txtNCartaoCliente.TabIndex = 31;
            // 
            // lblNCartaoCliente
            // 
            this.lblNCartaoCliente.AutoSize = true;
            this.lblNCartaoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNCartaoCliente.Location = new System.Drawing.Point(426, 112);
            this.lblNCartaoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNCartaoCliente.Name = "lblNCartaoCliente";
            this.lblNCartaoCliente.Size = new System.Drawing.Size(83, 13);
            this.lblNCartaoCliente.TabIndex = 30;
            this.lblNCartaoCliente.Text = "Nº do cartão:";
            // 
            // lblValorOfertaCliente
            // 
            this.lblValorOfertaCliente.AutoSize = true;
            this.lblValorOfertaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValorOfertaCliente.Location = new System.Drawing.Point(169, 112);
            this.lblValorOfertaCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorOfertaCliente.Name = "lblValorOfertaCliente";
            this.lblValorOfertaCliente.Size = new System.Drawing.Size(95, 13);
            this.lblValorOfertaCliente.TabIndex = 29;
            this.lblValorOfertaCliente.Text = "Valor de oferta:";
            // 
            // txtValorOfertaCliente
            // 
            this.txtValorOfertaCliente.DecimalPlaces = 2;
            this.txtValorOfertaCliente.Location = new System.Drawing.Point(269, 109);
            this.txtValorOfertaCliente.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtValorOfertaCliente.Name = "txtValorOfertaCliente";
            this.txtValorOfertaCliente.Size = new System.Drawing.Size(152, 20);
            this.txtValorOfertaCliente.TabIndex = 28;
            // 
            // txtLocalidadeCliente
            // 
            this.txtLocalidadeCliente.Location = new System.Drawing.Point(414, 78);
            this.txtLocalidadeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidadeCliente.Name = "txtLocalidadeCliente";
            this.txtLocalidadeCliente.Size = new System.Drawing.Size(216, 20);
            this.txtLocalidadeCliente.TabIndex = 27;
            // 
            // lblLocalidadeCliente
            // 
            this.lblLocalidadeCliente.AutoSize = true;
            this.lblLocalidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLocalidadeCliente.Location = new System.Drawing.Point(337, 81);
            this.lblLocalidadeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidadeCliente.Name = "lblLocalidadeCliente";
            this.lblLocalidadeCliente.Size = new System.Drawing.Size(73, 13);
            this.lblLocalidadeCliente.TabIndex = 26;
            this.lblLocalidadeCliente.Text = "Localidade:";
            // 
            // txtMoradaCliente
            // 
            this.txtMoradaCliente.Location = new System.Drawing.Point(68, 78);
            this.txtMoradaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoradaCliente.Name = "txtMoradaCliente";
            this.txtMoradaCliente.Size = new System.Drawing.Size(265, 20);
            this.txtMoradaCliente.TabIndex = 25;
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(365, 21);
            this.txtMailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(265, 20);
            this.txtMailCliente.TabIndex = 24;
            // 
            // lblMailCliente
            // 
            this.lblMailCliente.AutoSize = true;
            this.lblMailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMailCliente.Location = new System.Drawing.Point(327, 24);
            this.lblMailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailCliente.Name = "lblMailCliente";
            this.lblMailCliente.Size = new System.Drawing.Size(34, 13);
            this.lblMailCliente.TabIndex = 23;
            this.lblMailCliente.Text = "Mail:";
            // 
            // txtTelemovelCliente
            // 
            this.txtTelemovelCliente.Location = new System.Drawing.Point(84, 51);
            this.txtTelemovelCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelemovelCliente.MaxLength = 9;
            this.txtTelemovelCliente.Name = "txtTelemovelCliente";
            this.txtTelemovelCliente.Size = new System.Drawing.Size(239, 20);
            this.txtTelemovelCliente.TabIndex = 22;
            this.txtTelemovelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelemovelCliente_KeyPress);
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(392, 47);
            this.txtTelefoneCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefoneCliente.MaxLength = 9;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(238, 20);
            this.txtTelefoneCliente.TabIndex = 21;
            this.txtTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneCliente_KeyPress);
            // 
            // txtCodPostalCliente
            // 
            this.txtCodPostalCliente.Location = new System.Drawing.Point(105, 109);
            this.txtCodPostalCliente.Mask = "0000-999";
            this.txtCodPostalCliente.Name = "txtCodPostalCliente";
            this.txtCodPostalCliente.Size = new System.Drawing.Size(50, 20);
            this.txtCodPostalCliente.TabIndex = 20;
            // 
            // lblMoradaEscola
            // 
            this.lblMoradaEscola.AutoSize = true;
            this.lblMoradaEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMoradaEscola.Location = new System.Drawing.Point(11, 81);
            this.lblMoradaEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoradaEscola.Name = "lblMoradaEscola";
            this.lblMoradaEscola.Size = new System.Drawing.Size(53, 13);
            this.lblMoradaEscola.TabIndex = 18;
            this.lblMoradaEscola.Text = "Morada:";
            // 
            // lblCodPostalCliente
            // 
            this.lblCodPostalCliente.AutoSize = true;
            this.lblCodPostalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodPostalCliente.Location = new System.Drawing.Point(11, 112);
            this.lblCodPostalCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodPostalCliente.Name = "lblCodPostalCliente";
            this.lblCodPostalCliente.Size = new System.Drawing.Size(89, 13);
            this.lblCodPostalCliente.TabIndex = 15;
            this.lblCodPostalCliente.Text = "Código Postal:";
            // 
            // tabelaEscolas
            // 
            this.tabelaEscolas.AllowUserToAddRows = false;
            this.tabelaEscolas.AllowUserToDeleteRows = false;
            this.tabelaEscolas.AutoGenerateColumns = false;
            this.tabelaEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEscolas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.nrCartaoDataGridViewTextBoxColumn,
            this.valorOfertaDataGridViewTextBoxColumn});
            this.tabelaEscolas.DataSource = this.view3BindingSource;
            this.tabelaEscolas.Location = new System.Drawing.Point(2, 136);
            this.tabelaEscolas.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaEscolas.Name = "tabelaEscolas";
            this.tabelaEscolas.ReadOnly = true;
            this.tabelaEscolas.RowTemplate.Height = 24;
            this.tabelaEscolas.Size = new System.Drawing.Size(635, 209);
            this.tabelaEscolas.TabIndex = 8;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "Código Postal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telemovelDataGridViewTextBoxColumn
            // 
            this.telemovelDataGridViewTextBoxColumn.DataPropertyName = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.HeaderText = "Telemóvel";
            this.telemovelDataGridViewTextBoxColumn.Name = "telemovelDataGridViewTextBoxColumn";
            this.telemovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrCartaoDataGridViewTextBoxColumn
            // 
            this.nrCartaoDataGridViewTextBoxColumn.DataPropertyName = "NrCartao";
            this.nrCartaoDataGridViewTextBoxColumn.HeaderText = "Nº Cartão";
            this.nrCartaoDataGridViewTextBoxColumn.Name = "nrCartaoDataGridViewTextBoxColumn";
            this.nrCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorOfertaDataGridViewTextBoxColumn
            // 
            this.valorOfertaDataGridViewTextBoxColumn.DataPropertyName = "ValorOferta";
            this.valorOfertaDataGridViewTextBoxColumn.HeaderText = "Valor de oferta";
            this.valorOfertaDataGridViewTextBoxColumn.Name = "valorOfertaDataGridViewTextBoxColumn";
            this.valorOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // view3BindingSource
            // 
            this.view3BindingSource.DataMember = "View_3";
            this.view3BindingSource.DataSource = this.bdBookidsDataSet3;
            // 
            // bdBookidsDataSet3
            // 
            this.bdBookidsDataSet3.DataSetName = "bdBookidsDataSet3";
            this.bdBookidsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTelemovelCliente
            // 
            this.lblTelemovelCliente.AutoSize = true;
            this.lblTelemovelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelemovelCliente.Location = new System.Drawing.Point(11, 54);
            this.lblTelemovelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelemovelCliente.Name = "lblTelemovelCliente";
            this.lblTelemovelCliente.Size = new System.Drawing.Size(69, 13);
            this.lblTelemovelCliente.TabIndex = 4;
            this.lblTelemovelCliente.Text = "Telemóvel:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefoneCliente.Location = new System.Drawing.Point(327, 51);
            this.lblTelefoneCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(61, 13);
            this.lblTelefoneCliente.TabIndex = 2;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(58, 21);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(265, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.Location = new System.Drawing.Point(11, 24);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(43, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // panelGestaoClientes
            // 
            this.panelGestaoClientes.BackColor = System.Drawing.Color.Silver;
            this.panelGestaoClientes.Controls.Add(this.panelGestaoClientes2);
            this.panelGestaoClientes.Controls.Add(this.btnAlterarCliente);
            this.panelGestaoClientes.Controls.Add(this.btnInserirCliente);
            this.panelGestaoClientes.Controls.Add(this.btnEliminarCliente);
            this.panelGestaoClientes.Location = new System.Drawing.Point(9, 43);
            this.panelGestaoClientes.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoClientes.Name = "panelGestaoClientes";
            this.panelGestaoClientes.Size = new System.Drawing.Size(644, 409);
            this.panelGestaoClientes.TabIndex = 16;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCliente.Location = new System.Drawing.Point(490, 365);
            this.btnAlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(74, 33);
            this.btnAlterarCliente.TabIndex = 5;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCliente.Location = new System.Drawing.Point(412, 365);
            this.btnInserirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(74, 33);
            this.btnInserirCliente.TabIndex = 2;
            this.btnInserirCliente.Text = "Inserir";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(568, 365);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(74, 33);
            this.btnEliminarCliente.TabIndex = 1;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDataHora.Location = new System.Drawing.Point(502, 454);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(41, 13);
            this.lblDataHora.TabIndex = 17;
            this.lblDataHora.Text = "label1";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // view_3TableAdapter
            // 
            this.view_3TableAdapter.ClearBeforeFill = true;
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 476);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.panelGestaoClientes);
            this.Controls.Add(this.lbDataHora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes";
            this.Load += new System.EventHandler(this.FormGestaoClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).EndInit();
            this.panelGestaoClientes2.ResumeLayout(false);
            this.panelGestaoClientes2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCartaoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorOfertaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEscolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet3)).EndInit();
            this.panelGestaoClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoBarraFerramentas;
        private System.Windows.Forms.PictureBox pictureBoxSetaVoltar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.Label lbDataHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Panel panelGestaoClientes2;
        private System.Windows.Forms.Label lblMoradaEscola;
        private System.Windows.Forms.Label lblCodPostalCliente;
        private System.Windows.Forms.DataGridView tabelaEscolas;
        private System.Windows.Forms.Label lblTelemovelCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Panel panelGestaoClientes;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label lblDataHora;
        private bdBookidsDataSet3 bdBookidsDataSet3;
        private System.Windows.Forms.BindingSource view3BindingSource;
        private bdBookidsDataSet3TableAdapters.View_3TableAdapter view_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtCodPostalCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtTelemovelCliente;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.Label lblMailCliente;
        private System.Windows.Forms.TextBox txtMoradaCliente;
        private System.Windows.Forms.Label lblLocalidadeCliente;
        private System.Windows.Forms.TextBox txtLocalidadeCliente;
        private System.Windows.Forms.Label lblNCartaoCliente;
        private System.Windows.Forms.Label lblValorOfertaCliente;
        private System.Windows.Forms.NumericUpDown txtValorOfertaCliente;
        private System.Windows.Forms.NumericUpDown txtNCartaoCliente;
        private System.Windows.Forms.Button btnInserirCliente;
    }
}