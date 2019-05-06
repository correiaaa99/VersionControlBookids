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
    public partial class FormGestaoTiposProduto : Form
    {
        TipoProduto tipoProduto = new TipoProduto();
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public FormGestaoTiposProduto()
        {
            InitializeComponent();
        }
        private void FormGestaoTiposProduto_Load(object sender, EventArgs e)
        {
            //preencher o adaptador da tabela com os dados da classe
            this.tipoProdutoSet1TableAdapter.Fill(this.bdBookidsDataSet1.TipoProdutoSet1);
            limpar();
            tabelaTiposProduto.ClearSelection();
        }
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //criar messagebox
            funcionalidadesAplicacao.ajuda(this);
        }
        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //buscar método à class e passar por parâmetro o form
            funcionalidadesAplicacao.sair(this);
        }
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = funcionalidadesAplicacao.getDataHora();
        }
        private void btnInserirTipoProduto_Click(object sender, EventArgs e)
        {
            if(txtNomeTipoProduto.Text.Trim() == "")
            {
                DialogResult result = MessageBox.Show("É obrigatório preencher corretamente a caixa de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //meter cursor na caixa de texto
                txtNomeTipoProduto.Focus();
            }
            else
            {   
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                {
                    //testar se ja existe o tipo de produto na base de dados
                    string resultado  = Convert.ToString(db.TipoProdutoSet1.Where(x => x.Tipo == txtNomeTipoProduto.Text.Trim()).FirstOrDefault());
                    if(resultado == "")
                    {
                        //passar valor da caixa de texto para o atributo tipo da classe
                        tipoProduto.Tipo = txtNomeTipoProduto.Text.Trim();
                        //adicinar a classe o novo tipo de produto
                        db.TipoProdutoSet1.Add(tipoProduto);
                        db.SaveChanges();
                        DialogResult result = MessageBox.Show("Tipo de produto inserido com sucesso!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult aviso = MessageBox.Show("Já existe um tipo de produto com essa designação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                     
                    }
                }
                atualizarAdaptadorTabela();
                tabelaTiposProduto.ClearSelection();
                limpar();
            }  
        }
        private void limpar()
        {
            //limpar caixas de texto
            txtNomeTipoProduto.Clear();
        }
        private void btnAlterarTipoProduto_Click(object sender, EventArgs e)
        {
            //testar se existe alguma linha selecionada
            if(tabelaTiposProduto.SelectedRows.Count > 0)
            {  
                if(txtNomeTipoProduto.Text.Trim() == "")
                {
                    DialogResult result = MessageBox.Show("É obrigatório preencher corretamente a caixa de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //meter cursor na caixa de texto
                    txtNomeTipoProduto.Focus();
                }
                else
                {
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //alterar registo
                        tipoProduto.CodTipoProduto = Convert.ToInt32(tabelaTiposProduto.CurrentRow.Cells["codTipoProduto"].Value);
                        tipoProduto.Tipo = txtNomeTipoProduto.Text.Trim();
                        db.Entry(tipoProduto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        limpar();
                        DialogResult result = MessageBox.Show("Tipo de produto alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                limpar();
                atualizarAdaptadorTabela();
                tabelaTiposProduto.ClearSelection();
            }
            else
            { 
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnEliminarTipoProduto_Click(object sender, EventArgs e)
        {
            if(tabelaTiposProduto.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja eliminar o tipo de produto " + tipoProduto.CodTipoProduto + " - " + tipoProduto.Tipo + "?" , "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //buscar objeto que corresponde ao codigo selecionado     
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //encontrar objeto que corresponde ao codigo 
                        tipoProduto = db.TipoProdutoSet1.Where(x => x.CodTipoProduto == tipoProduto.CodTipoProduto).FirstOrDefault();
                    }
                    try
                    {
                        using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                        {
                            db.TipoProdutoSet1.Attach(tipoProduto);
                            db.TipoProdutoSet1.Remove(tipoProduto);
                            db.SaveChanges();
                           
                            DialogResult result = MessageBox.Show("Tipo de produto eliminado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Não é possível eliminar o tipo de produto porque está relacionado com um produto!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                atualizarAdaptadorTabela();
                tabelaTiposProduto.ClearSelection();
                limpar();
            }
            else
            {
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void atualizarAdaptadorTabela()
        {
            //resetar a data set 
            this.bdBookidsDataSet1.Reset();
            //preencher o adaptador da tabela
            this.tipoProdutoSet1TableAdapter.Fill(bdBookidsDataSet1.TipoProdutoSet1);
        }
        private void pictureBoxSetaVoltar_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário principal
            formPrincipal formPrincipal = new formPrincipal();
            funcionalidadesAplicacao.escolherForm(formPrincipal, this);
        }

        private void tabelaTiposProduto_Click(object sender, EventArgs e)
        {
            if(tabelaTiposProduto.SelectedRows.Count > 0)
            {
                //passar o codigo da linha selecionada para o atributo
                tipoProduto.CodTipoProduto = Convert.ToInt32(tabelaTiposProduto.CurrentRow.Cells["codTipoProduto"].Value);
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                {
                    //criar objetos com os dados da linha selecionada
                    tipoProduto = db.TipoProdutoSet1.Where(x => x.CodTipoProduto == tipoProduto.CodTipoProduto).FirstOrDefault();
                    txtNomeTipoProduto.Text = tipoProduto.Tipo;
                }
            }
        }
    }
}
