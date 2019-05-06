using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class FormGestaoProdutos : Form
    {
        TipoProduto tipoProduto = new TipoProduto();
        Produtos produto = new Produtos();
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public FormGestaoProdutos()
        {
            InitializeComponent();
           
        }
        private void FormGestaoProdutos_Load(object sender, EventArgs e)
        {
            //carregar automaticamente os dados da tabela através da view criada no sql
            this.view_2TableAdapter.Fill(this.bdBookidsDataSet9.View_2); 
            //carregar automaticamente os dados da tabela tipo de produtos na data binding da combo box 
            this.tipoProdutoSet1TableAdapter.Fill(this.bdBookidsDataSet.TipoProdutoSet1);
            this.ddTipoProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            produto.TipoProdutoCodTipoProduto = buscarCodigo();
            tabelaProdutos.ClearSelection();
        }
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = funcionalidadesAplicacao.getDataHora();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            funcionalidadesAplicacao.ajuda(this);
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //buscar método à class e passar por parâmetro o form
            funcionalidadesAplicacao.sair(this);
        }

        private void pictureBoxSetaVoltar_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário principal
            formPrincipal formPrincipal = new formPrincipal();
            funcionalidadesAplicacao.escolherForm(formPrincipal, this);
        }
        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            //testes de validação
            if (txtDesignacaoProduto.Text.Trim() == "")
            {
                DialogResult result = MessageBox.Show("É obrigatório preencher corretamente a caixa de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtPreco.Value.ToString() == "0")
            {
                DialogResult result = MessageBox.Show("É obrigatório inserir um preço positivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if(ddTipoProduto.Text == "")
            {
                DialogResult result = MessageBox.Show("É obrigatório inserir um tipo de produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                { 
                    produto.Designacao = txtDesignacaoProduto.Text.Trim();
                    produto.Preco = txtPreco.Value;
                    produto.StockExistente = Convert.ToInt32(txtStock.Value);
                    //adicinar a classe o novo produto
                    db.ProdutosSet.Add(produto);
                    db.SaveChanges();
                    limpar();
                    DialogResult result = MessageBox.Show("Produto inserido com sucesso!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
                atualizarAdaptadorTabela();
                tabelaProdutos.ClearSelection();
                limpar();
            }        
        }

        private void ddTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto.TipoProdutoCodTipoProduto = buscarCodigo();
        }
        private void limpar()
        {
            txtStock.Value = 0;
            txtPreco.Value = 0;
            txtDesignacaoProduto.Text = "";
            ddTipoProduto.SelectedIndex = 0;
        }
        private int buscarCodigo()
        { 
            //passar codigo da combox para os objetos
            return Convert.ToInt32(ddTipoProduto.SelectedValue);
        }

        private void tabelaProdutos_Click(object sender, EventArgs e)
        {
            if (tabelaProdutos.SelectedRows.Count > 0)
            {
                //passar o codigo da linha selecionada para o atributo
                produto.CodProduto = Convert.ToInt32(tabelaProdutos.CurrentRow.Cells["codProdutoDataGridViewTextBoxColumn"].Value);
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                {
                    //criar objetos com os dados da linha selecionada
                    produto = db.ProdutosSet.Where(x => x.CodProduto == produto.CodProduto).FirstOrDefault();
                    tipoProduto = db.TipoProdutoSet1.Where(x => x.CodTipoProduto == produto.TipoProdutoCodTipoProduto).FirstOrDefault();
                    txtDesignacaoProduto.Text = produto.Designacao;
                    txtPreco.Value = produto.Preco;
                    txtStock.Value = produto.StockExistente;
                    ddTipoProduto.Text = tipoProduto.Tipo;
                }
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            //testar se existe alguma linha selecionada
            if (tabelaProdutos.SelectedRows.Count > 0)
            {
                //testes de validação
                if (txtDesignacaoProduto.Text.Trim() == "")
                {
                    DialogResult result = MessageBox.Show("É obrigatório preencher corretamente a caixa de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtPreco.Value.ToString() == "0")
                {
                    DialogResult result = MessageBox.Show("É obrigatório inserir um preço positivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ddTipoProduto.Text == "")
                {
                    DialogResult result = MessageBox.Show("É obrigatório inserir um tipo de produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //alterar registo
                        produto.CodProduto = Convert.ToInt32(tabelaProdutos.CurrentRow.Cells["codProdutoDataGridViewTextBoxColumn"].Value);
                        produto.Designacao = txtDesignacaoProduto.Text.Trim();
                        produto.Preco = txtPreco.Value;
                        produto.StockExistente = Convert.ToInt32(txtStock.Value);
                        db.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        DialogResult result = MessageBox.Show("Produto alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        atualizarAdaptadorTabela();
                        tabelaProdutos.ClearSelection();
                    }                  
                }
              
            }
            else
            {
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void atualizarAdaptadorTabela()
        {
            //resetar a data set 
            this.bdBookidsDataSet9.Reset();
            //preencher o adaptador da tabela
            this.view_2TableAdapter.Fill(bdBookidsDataSet9.View_2);
        }

        private void btnEliminarProduto_Click(object sender, EventArgs e)
        {
            if (tabelaProdutos.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja eliminar o produto " + produto.CodProduto + " - " + produto.Designacao + "?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //buscar objeto que corresponde ao codigo selecionado     
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //encontrar objeto que corresponde ao codigo 
                        produto = db.ProdutosSet.Where(x => x.CodProduto == produto.CodProduto).FirstOrDefault();
                    }
                    try
                    {
                        using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                        {
                            db.ProdutosSet.Attach(produto);
                            db.ProdutosSet.Remove(produto);
                            db.SaveChanges();
                            DialogResult result = MessageBox.Show("Produto eliminado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não é possível eliminar o produto!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                atualizarAdaptadorTabela();
                tabelaProdutos.ClearSelection();
                limpar();
            }
            else
            {
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
