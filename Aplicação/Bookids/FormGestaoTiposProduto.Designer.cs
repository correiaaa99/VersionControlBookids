namespace Bookids
{
    partial class FormGestaoTiposProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestaoTiposProduto));
            this.tipoProdutoSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBookidsDataSet1 = new Bookids.bdBookidsDataSet1();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.tipoProdutoSet1TableAdapter = new Bookids.bdBookidsDataSet1TableAdapters.TipoProdutoSet1TableAdapter();
            this.btnEliminarTipoProduto = new System.Windows.Forms.Button();
            this.btnInserirTipoProduto = new System.Windows.Forms.Button();
            this.lbNomeTipoProduto = new System.Windows.Forms.Label();
            this.txtNomeTipoProduto = new System.Windows.Forms.TextBox();
            this.btnAlterarTipoProduto = new System.Windows.Forms.Button();
            this.panelGestaoTiposProduto = new System.Windows.Forms.Panel();
            this.tabelaTiposProduto = new System.Windows.Forms.DataGridView();
            this.codTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbLogoBarraFerramentas = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.pictureBoxSetaVoltar = new System.Windows.Forms.PictureBox();
            this.panelBarraFerramentas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet1)).BeginInit();
            this.panelGestaoTiposProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTiposProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).BeginInit();
            this.panelBarraFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoProdutoSet1BindingSource
            // 
            this.tipoProdutoSet1BindingSource.DataMember = "TipoProdutoSet1";
            this.tipoProdutoSet1BindingSource.DataSource = this.bdBookidsDataSet1;
            // 
            // bdBookidsDataSet1
            // 
            this.bdBookidsDataSet1.DataSetName = "bdBookidsDataSet1";
            this.bdBookidsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDataHora.Location = new System.Drawing.Point(506, 429);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(41, 13);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "label1";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // tipoProdutoSet1TableAdapter
            // 
            this.tipoProdutoSet1TableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarTipoProduto
            // 
            this.btnEliminarTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoProduto.Location = new System.Drawing.Point(568, 338);
            this.btnEliminarTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTipoProduto.Name = "btnEliminarTipoProduto";
            this.btnEliminarTipoProduto.Size = new System.Drawing.Size(74, 33);
            this.btnEliminarTipoProduto.TabIndex = 1;
            this.btnEliminarTipoProduto.Text = "Eliminar";
            this.btnEliminarTipoProduto.UseVisualStyleBackColor = true;
            this.btnEliminarTipoProduto.Click += new System.EventHandler(this.btnEliminarTipoProduto_Click);
            // 
            // btnInserirTipoProduto
            // 
            this.btnInserirTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirTipoProduto.Location = new System.Drawing.Point(412, 338);
            this.btnInserirTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirTipoProduto.Name = "btnInserirTipoProduto";
            this.btnInserirTipoProduto.Size = new System.Drawing.Size(74, 33);
            this.btnInserirTipoProduto.TabIndex = 2;
            this.btnInserirTipoProduto.Text = "Inserir";
            this.btnInserirTipoProduto.UseVisualStyleBackColor = true;
            this.btnInserirTipoProduto.Click += new System.EventHandler(this.btnInserirTipoProduto_Click);
            // 
            // lbNomeTipoProduto
            // 
            this.lbNomeTipoProduto.AutoSize = true;
            this.lbNomeTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeTipoProduto.Location = new System.Drawing.Point(13, 317);
            this.lbNomeTipoProduto.Name = "lbNomeTipoProduto";
            this.lbNomeTipoProduto.Size = new System.Drawing.Size(191, 13);
            this.lbNomeTipoProduto.TabIndex = 3;
            this.lbNomeTipoProduto.Text = "Designação do Tipo de Produto:";
            // 
            // txtNomeTipoProduto
            // 
            this.txtNomeTipoProduto.Location = new System.Drawing.Point(210, 314);
            this.txtNomeTipoProduto.Multiline = true;
            this.txtNomeTipoProduto.Name = "txtNomeTipoProduto";
            this.txtNomeTipoProduto.Size = new System.Drawing.Size(431, 19);
            this.txtNomeTipoProduto.TabIndex = 4;
            // 
            // btnAlterarTipoProduto
            // 
            this.btnAlterarTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarTipoProduto.Location = new System.Drawing.Point(490, 338);
            this.btnAlterarTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarTipoProduto.Name = "btnAlterarTipoProduto";
            this.btnAlterarTipoProduto.Size = new System.Drawing.Size(74, 33);
            this.btnAlterarTipoProduto.TabIndex = 5;
            this.btnAlterarTipoProduto.Text = "Alterar";
            this.btnAlterarTipoProduto.UseVisualStyleBackColor = true;
            this.btnAlterarTipoProduto.Click += new System.EventHandler(this.btnAlterarTipoProduto_Click);
            // 
            // panelGestaoTiposProduto
            // 
            this.panelGestaoTiposProduto.BackColor = System.Drawing.Color.Silver;
            this.panelGestaoTiposProduto.Controls.Add(this.btnAlterarTipoProduto);
            this.panelGestaoTiposProduto.Controls.Add(this.txtNomeTipoProduto);
            this.panelGestaoTiposProduto.Controls.Add(this.lbNomeTipoProduto);
            this.panelGestaoTiposProduto.Controls.Add(this.btnInserirTipoProduto);
            this.panelGestaoTiposProduto.Controls.Add(this.btnEliminarTipoProduto);
            this.panelGestaoTiposProduto.Controls.Add(this.tabelaTiposProduto);
            this.panelGestaoTiposProduto.Location = new System.Drawing.Point(9, 43);
            this.panelGestaoTiposProduto.Margin = new System.Windows.Forms.Padding(2);
            this.panelGestaoTiposProduto.Name = "panelGestaoTiposProduto";
            this.panelGestaoTiposProduto.Size = new System.Drawing.Size(644, 379);
            this.panelGestaoTiposProduto.TabIndex = 13;
            // 
            // tabelaTiposProduto
            // 
            this.tabelaTiposProduto.AllowUserToAddRows = false;
            this.tabelaTiposProduto.AllowUserToDeleteRows = false;
            this.tabelaTiposProduto.AutoGenerateColumns = false;
            this.tabelaTiposProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTiposProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoProduto,
            this.tipo});
            this.tabelaTiposProduto.DataSource = this.tipoProdutoSet1BindingSource;
            this.tabelaTiposProduto.Location = new System.Drawing.Point(2, 2);
            this.tabelaTiposProduto.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaTiposProduto.Name = "tabelaTiposProduto";
            this.tabelaTiposProduto.ReadOnly = true;
            this.tabelaTiposProduto.RowTemplate.Height = 24;
            this.tabelaTiposProduto.Size = new System.Drawing.Size(640, 304);
            this.tabelaTiposProduto.TabIndex = 0;
            this.tabelaTiposProduto.Click += new System.EventHandler(this.tabelaTiposProduto_Click);
            // 
            // codTipoProduto
            // 
            this.codTipoProduto.DataPropertyName = "CodTipoProduto";
            this.codTipoProduto.HeaderText = "Código";
            this.codTipoProduto.Name = "codTipoProduto";
            this.codTipoProduto.ReadOnly = true;
            this.codTipoProduto.Width = 287;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "Tipo";
            this.tipo.HeaderText = "Designação";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 310;
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
            this.panelBarraFerramentas.TabIndex = 0;
            // 
            // FormGestaoTiposProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.panelGestaoTiposProduto);
            this.Controls.Add(this.panelBarraFerramentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoTiposProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tipos de Produto";
            this.Load += new System.EventHandler(this.FormGestaoTiposProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBookidsDataSet1)).EndInit();
            this.panelGestaoTiposProduto.ResumeLayout(false);
            this.panelGestaoTiposProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTiposProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBarraFerramentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetaVoltar)).EndInit();
            this.panelBarraFerramentas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerDataHora;
        private bdBookidsDataSet1 bdBookidsDataSet1;
        private System.Windows.Forms.BindingSource tipoProdutoSet1BindingSource;
        private bdBookidsDataSet1TableAdapters.TipoProdutoSet1TableAdapter tipoProdutoSet1TableAdapter;
        private System.Windows.Forms.Button btnEliminarTipoProduto;
        private System.Windows.Forms.Button btnInserirTipoProduto;
        private System.Windows.Forms.Label lbNomeTipoProduto;
        private System.Windows.Forms.TextBox txtNomeTipoProduto;
        private System.Windows.Forms.Button btnAlterarTipoProduto;
        private System.Windows.Forms.Panel panelGestaoTiposProduto;
        private System.Windows.Forms.DataGridView tabelaTiposProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.PictureBox pbLogoBarraFerramentas;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.PictureBox pictureBoxSetaVoltar;
        private System.Windows.Forms.Panel panelBarraFerramentas;
    }
}