namespace Bookids
{
    partial class FormGestaoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestaoProdutos));
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.panelBarraFerramentas = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.pbLogoBarraFerramentas = new System.Windows.Forms.PictureBox();
            this.pictureBoxSetaVoltar = new System.Windows.Forms.PictureBox();
            this.panelGestaoProdutos = new System.Windows.Forms.Panel();
            this.panelGestaoProdutos2 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockExistenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBookidsDataSet9 = new Bookids.bdBookidsDataSet9();
            this.lblStock = new System.Windows.Forms.Label();
            this.ddTipoProduto = new System.Windows.Forms.ComboBox();
            this.tipoProdutoSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBookidsDataSet = new Bookids.bdBookidsDataSet();
            this.lblCodigoTipoProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.txtDesignacaoProduto = new System.Windows.Forms.TextBox();
            this.lblDesignacaoProduto = new System.Windows.Forms.Label();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnEliminarProduto = new System.Windows.Forms.Button();
            this.tipoProdutoSet1TableAdapter = new Bookids.bdBookidsDataSetTableAdapters.TipoProdutoSet1TableAdapter();
            this.view_2TableAdapter = new Bookids.bdBookidsDataSet9TableAdapters.View_2TableAdapter();
            this.panelBarraFerramentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).BeginInit();
            this.panelGestaoProdutos.SuspendLayout();
            this.panelGestaoProdutos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDataHora.Location = new System.Drawing.Point(506, 429);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(41, 13);
            this.lblDataHora.TabIndex = 4;
            this.lblDataHora.Text = "label1";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // panelBarraFerramentas
            // 
            this.panelBarraFerramentas.BackColor = System.Drawing.Color.Silver;
            this.panelBarraFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraFerramentas.Controls.Add(this.btnAjuda);
            this.panelBarraFerramentas.Controls.Add(this.btnSairMenu);
            this.panelBarraFerramentas.Controls.Add(this.pbLogoBarraFerramentas);
            this.panelBarraFerramentas.Controls.Add(this.pictureBoxSetaVoltar);
            this.panelBarraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.panelBarraFerramentas.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraFerramentas.Name = "panelBarraFerramentas";
            this.panelBarraFerramentas.Size = new System.Drawing.Size(664, 38);
            this.panelBarraFerramentas.TabIndex = 5;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(518, 6);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(65, 26);
            this.btnAjuda.TabIndex = 9;
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
            this.btnSairMenu.TabIndex = 8;
            this.btnSairMenu.Text = "Sair";
            this.btnSairMenu.UseVisualStyleBackColor = true;
            this.btnSairMenu.Click += new System.EventHandler(this.btnSairMenu_Click);
            // 
            // pbLogoBarraFerramentas
            // 
            this.pbLogoBarraFerramentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogoBarraFerramentas.BackgroundImage")));
            this.pbLogoBarraFerramentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoBarraFerramentas.Location = new System.Drawing.Point(280, -1);
            this.pbLogoBarraFerramentas.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoBarraFerramentas.Name = "pbLogoBarraFerramentas";
            this.pbLogoBarraFerramentas.Size = new System.Drawing.Size(101, 37);
            this.pbLogoBarraFerramentas.TabIndex = 6;
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
            this.pictureBoxSetaVoltar.TabIndex = 5;
            this.pictureBoxSetaVoltar.TabStop = false;
            this.pictureBoxSetaVoltar.Click += new System.EventHandler(this.pictureBoxSetaVoltar_Click);
            // 
            // panelGestaoProdutos
            // 
            this.panelGestaoProdutos.BackColor = System.Drawing.Color.Silver;
            this.panelGestaoProdutos.Controls.Add(this.panelGestaoProdutos2);
            this.panelGestaoProdutos.Controls.Add(this.btnAlterarProduto);
            this.panelGestaoProdutos.Controls.Add(this.btnInserirProduto);
            this.panelGestaoProdutos.Controls.Add(this.btnEliminarProduto);
            this.panelGestaoProdutos.Location = new System.Drawing.Point(9, 43);
            this.panelGestaoProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoProdutos.Name = "panelGestaoProdutos";
            this.panelGestaoProdutos.Size = new System.Drawing.Size(644, 379);
            this.panelGestaoProdutos.TabIndex = 14;
            // 
            // panelGestaoProdutos2
            // 
            this.panelGestaoProdutos2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGestaoProdutos2.Controls.Add(this.txtStock);
            this.panelGestaoProdutos2.Controls.Add(this.txtPreco);
            this.panelGestaoProdutos2.Controls.Add(this.tabelaProdutos);
            this.panelGestaoProdutos2.Controls.Add(this.lblStock);
            this.panelGestaoProdutos2.Controls.Add(this.ddTipoProduto);
            this.panelGestaoProdutos2.Controls.Add(this.lblCodigoTipoProduto);
            this.panelGestaoProdutos2.Controls.Add(this.lblPrecoProduto);
            this.panelGestaoProdutos2.Controls.Add(this.txtDesignacaoProduto);
            this.panelGestaoProdutos2.Controls.Add(this.lblDesignacaoProduto);
            this.panelGestaoProdutos2.Location = new System.Drawing.Point(2, 2);
            this.panelGestaoProdutos2.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoProdutos2.Name = "panelGestaoProdutos2";
            this.panelGestaoProdutos2.Size = new System.Drawing.Size(640, 332);
            this.panelGestaoProdutos2.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(466, 65);
            this.txtStock.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(153, 20);
            this.txtStock.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.DecimalPlaces = 2;
            this.txtPreco.Location = new System.Drawing.Point(467, 23);
            this.txtPreco.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.AutoGenerateColumns = false;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.designacaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.stockExistenteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn});
            this.tabelaProdutos.DataSource = this.view2BindingSource;
            this.tabelaProdutos.Location = new System.Drawing.Point(2, 102);
            this.tabelaProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.RowTemplate.Height = 24;
            this.tabelaProdutos.Size = new System.Drawing.Size(635, 228);
            this.tabelaProdutos.TabIndex = 8;
            this.tabelaProdutos.Click += new System.EventHandler(this.tabelaProdutos_Click);
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designacaoDataGridViewTextBoxColumn
            // 
            this.designacaoDataGridViewTextBoxColumn.DataPropertyName = "Designacao";
            this.designacaoDataGridViewTextBoxColumn.HeaderText = "Designação";
            this.designacaoDataGridViewTextBoxColumn.Name = "designacaoDataGridViewTextBoxColumn";
            this.designacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.designacaoDataGridViewTextBoxColumn.Width = 137;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockExistenteDataGridViewTextBoxColumn
            // 
            this.stockExistenteDataGridViewTextBoxColumn.DataPropertyName = "StockExistente";
            this.stockExistenteDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockExistenteDataGridViewTextBoxColumn.Name = "stockExistenteDataGridViewTextBoxColumn";
            this.stockExistenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Produto";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 155;
            // 
            // tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn
            // 
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "TipoProdutoCodTipoProduto";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.HeaderText = "TipoProdutoCodTipoProduto";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.Name = "tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.bdBookidsDataSet9;
            // 
            // bdBookidsDataSet9
            // 
            this.bdBookidsDataSet9.DataSetName = "bdBookidsDataSet9";
            this.bdBookidsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(417, 67);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // ddTipoProduto
            // 
            this.ddTipoProduto.DataSource = this.tipoProdutoSet1BindingSource;
            this.ddTipoProduto.DisplayMember = "Tipo";
            this.ddTipoProduto.FormattingEnabled = true;
            this.ddTipoProduto.Location = new System.Drawing.Point(129, 61);
            this.ddTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.ddTipoProduto.Name = "ddTipoProduto";
            this.ddTipoProduto.Size = new System.Drawing.Size(282, 21);
            this.ddTipoProduto.TabIndex = 5;
            this.ddTipoProduto.ValueMember = "CodTipoProduto";
            this.ddTipoProduto.SelectedIndexChanged += new System.EventHandler(this.ddTipoProduto_SelectedIndexChanged);
            // 
            // tipoProdutoSet1BindingSource
            // 
            this.tipoProdutoSet1BindingSource.DataMember = "TipoProdutoSet1";
            this.tipoProdutoSet1BindingSource.DataSource = this.bdBookidsDataSet;
            // 
            // bdBookidsDataSet
            // 
            this.bdBookidsDataSet.DataSetName = "bdBookidsDataSet";
            this.bdBookidsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCodigoTipoProduto
            // 
            this.lblCodigoTipoProduto.AutoSize = true;
            this.lblCodigoTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigoTipoProduto.Location = new System.Drawing.Point(13, 67);
            this.lblCodigoTipoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoTipoProduto.Name = "lblCodigoTipoProduto";
            this.lblCodigoTipoProduto.Size = new System.Drawing.Size(102, 13);
            this.lblCodigoTipoProduto.TabIndex = 4;
            this.lblCodigoTipoProduto.Text = "Tipo de Produto:";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecoProduto.Location = new System.Drawing.Point(417, 25);
            this.lblPrecoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(44, 13);
            this.lblPrecoProduto.TabIndex = 2;
            this.lblPrecoProduto.Text = "Preço:";
            // 
            // txtDesignacaoProduto
            // 
            this.txtDesignacaoProduto.Location = new System.Drawing.Point(103, 21);
            this.txtDesignacaoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignacaoProduto.Name = "txtDesignacaoProduto";
            this.txtDesignacaoProduto.Size = new System.Drawing.Size(307, 20);
            this.txtDesignacaoProduto.TabIndex = 1;
            // 
            // lblDesignacaoProduto
            // 
            this.lblDesignacaoProduto.AutoSize = true;
            this.lblDesignacaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDesignacaoProduto.Location = new System.Drawing.Point(13, 25);
            this.lblDesignacaoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignacaoProduto.Name = "lblDesignacaoProduto";
            this.lblDesignacaoProduto.Size = new System.Drawing.Size(78, 13);
            this.lblDesignacaoProduto.TabIndex = 0;
            this.lblDesignacaoProduto.Text = "Designação:";
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.Location = new System.Drawing.Point(490, 338);
            this.btnAlterarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(74, 33);
            this.btnAlterarProduto.TabIndex = 5;
            this.btnAlterarProduto.Text = "Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProduto.Location = new System.Drawing.Point(412, 338);
            this.btnInserirProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(74, 33);
            this.btnInserirProduto.TabIndex = 2;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnEliminarProduto
            // 
            this.btnEliminarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProduto.Location = new System.Drawing.Point(568, 338);
            this.btnEliminarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProduto.Name = "btnEliminarProduto";
            this.btnEliminarProduto.Size = new System.Drawing.Size(74, 33);
            this.btnEliminarProduto.TabIndex = 1;
            this.btnEliminarProduto.Text = "Eliminar";
            this.btnEliminarProduto.UseVisualStyleBackColor = true;
            this.btnEliminarProduto.Click += new System.EventHandler(this.btnEliminarProduto_Click);
            // 
            // tipoProdutoSet1TableAdapter
            // 
            this.tipoProdutoSet1TableAdapter.ClearBeforeFill = true;
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // FormGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.panelGestaoProdutos);
            this.Controls.Add(this.panelBarraFerramentas);
            this.Controls.Add(this.lblDataHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Produtos";
            this.Load += new System.EventHandler(this.FormGestaoProdutos_Load);
            this.panelBarraFerramentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).EndInit();
            this.panelGestaoProdutos.ResumeLayout(false);
            this.panelGestaoProdutos2.ResumeLayout(false);
            this.panelGestaoProdutos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Panel panelBarraFerramentas;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.PictureBox pbLogoBarraFerramentas;
        private System.Windows.Forms.PictureBox pictureBoxSetaVoltar;
        private System.Windows.Forms.Panel panelGestaoProdutos;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnEliminarProduto;
        private System.Windows.Forms.Panel panelGestaoProdutos2;
        private System.Windows.Forms.Label lblDesignacaoProduto;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.TextBox txtDesignacaoProduto;
        private System.Windows.Forms.Label lblCodigoTipoProduto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.ComboBox ddTipoProduto;
        private bdBookidsDataSet bdBookidsDataSet;
        private System.Windows.Forms.BindingSource tipoProdutoSet1BindingSource;
        private bdBookidsDataSetTableAdapters.TipoProdutoSet1TableAdapter tipoProdutoSet1TableAdapter;
        private System.Windows.Forms.NumericUpDown txtStock;
        private bdBookidsDataSet9 bdBookidsDataSet9;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private bdBookidsDataSet9TableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockExistenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn;
    }
}