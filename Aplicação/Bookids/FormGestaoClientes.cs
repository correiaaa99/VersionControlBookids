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
    public partial class FormGestaoClientes : Form
    {
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public FormGestaoClientes()
        {
            InitializeComponent(); 
        }

        private void FormGestaoClientes_Load(object sender, EventArgs e)
        {        
            this.view_3TableAdapter.Fill(this.bdBookidsDataSet3.View_3);
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            funcionalidadesAplicacao.ajuda(this);
        }

        private void pictureBoxSetaVoltar_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário principal
            formPrincipal formPrincipal = new formPrincipal();
            funcionalidadesAplicacao.escolherForm(formPrincipal, this);
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //buscar método à class e passar por parâmetro o form
            funcionalidadesAplicacao.sair(this);
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            //buscar data e hora atual
            lbDataHora.Text = funcionalidadesAplicacao.getDataHora();
        }

        private void txtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelemovelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {

        }  
        private bool validarCaixasDeTexto()
        {
            if (txtNomeCliente.Text.Trim() == "" || txtCodPostalCliente.Text.Trim().Length < 8 || txtMailCliente.Text.Trim() == "" ||
                txtTelemovelCliente.Text.Trim() == "" || txtTelefoneCliente.Text.Trim() == "" || txtTelefoneCliente.Text.Trim().Length < 9 || txtTelemovelCliente.Text.Trim().Length < 9 || txtMoradaCliente.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
    }
}
