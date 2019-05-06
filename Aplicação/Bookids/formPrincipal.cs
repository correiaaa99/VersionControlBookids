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
    public partial class formPrincipal : Form
    {
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public formPrincipal()
        {
            InitializeComponent();
        }
        private void formPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnGestaoFilhos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGestaoDetalhesCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //criar messagebox
            funcionalidadesAplicacao.ajuda(this);
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //buscar método à class e passar por parâmetro o form
            funcionalidadesAplicacao.sair(formPrincipal.ActiveForm);
        }

        private void pictureBoxSetaVoltar_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário principal
            formPaginaInicial formPaginaInicial = new formPaginaInicial();
            funcionalidadesAplicacao.escolherForm(formPaginaInicial, this);
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário de clientes
            FormGestaoClientes formGestaoClientes = new FormGestaoClientes();
            funcionalidadesAplicacao.escolherForm(formGestaoClientes, this);
        }

        private void btnGestaoTipoProduto_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário de tipos de produto
            FormGestaoTiposProduto formGestaoTiposProduto = new FormGestaoTiposProduto();
            funcionalidadesAplicacao.escolherForm(formGestaoTiposProduto, this);
        }

        private void btnGestaoProdutos_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário de produtos
            FormGestaoProdutos formGestaoProdutos = new FormGestaoProdutos();
            funcionalidadesAplicacao.escolherForm(formGestaoProdutos, this);
        }

        private void btnGestaoEscolas_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário de escolas
            FormGestaoEscolas formGestaoEscolas = new FormGestaoEscolas();
            funcionalidadesAplicacao.escolherForm(formGestaoEscolas, this);
        }
    }
}
