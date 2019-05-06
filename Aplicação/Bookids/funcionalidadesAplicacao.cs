using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    class funcionalidadesAplicacao
    {
       public void sair(Form form)
       {
            //Aviso para sair da aplicação
            DialogResult result = MessageBox.Show("Tem a certeza que pretende sair da aplicação?", "Saída",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                form.Close();
            }
       }
        public void ajuda(Form form1)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form1 is FormGestaoClientes)
                {
                    DialogResult result = MessageBox.Show("Esta página irá servir para efetuar a gestão dos clientes no sistema. Para alterar ou eliminar um registo deverá clicar na linha desejada na tabela!","Ajuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
                else if(form1 is formPrincipal)
                {
                    DialogResult result = MessageBox.Show("Esta página irá servir para efetuar a gestão da informação relativa aos seus clientes, escolas, animadores e eventos que organiza.", "Ajuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }  
                else if(form1 is FormGestaoTiposProduto)
                {
                   DialogResult result = MessageBox.Show("Esta página irá servir para efetuar a gestão dos tipos de produto no sistema. Para alterar ou eliminar um registo deverá clicar na linha desejada na tabela!", "Ajuda",
                   MessageBoxButtons.OK, MessageBoxIcon.Question);
                   break;
                }
                else if(form1 is FormGestaoProdutos)
                {
                    DialogResult result = MessageBox.Show("Esta página irá servir para efetuar a gestão dos produtos no sistema. Para alterar ou eliminar um registo deverá clicar na linha desejada na tabela!", "Ajuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
                else if(form1 is FormGestaoEscolas)
                {
                    DialogResult result = MessageBox.Show("Esta página irá servir para efetuar a gestão das escolas no sistema. Para alterar ou eliminar um registo deverá clicar na linha desejada na tabela!", "Ajuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
            }
        }
       public void escolherForm(Form formAmostrar, Form formAEsconder)
       {
            formAEsconder.Hide();
            formAmostrar.ShowDialog();
            formAEsconder.Close();
       }
        public string getDataHora()
        {
            var time = DateTime.Now;
            string stringFormatada;
            return stringFormatada = time.ToString("yyyy/MM/dd - HH: mm: ss");
        }
    }
}
