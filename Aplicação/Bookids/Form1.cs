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
    public partial class formPaginaInicial : Form
    {
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public formPaginaInicial()
        {
            InitializeComponent();
        }

        private void formPaginaInicial_Load(object sender, EventArgs e)
        {
         
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Abrir o form do formulário principal
            formPrincipal formPrincipal = new formPrincipal();
            funcionalidadesAplicacao.escolherForm(formPrincipal, this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //buscar método à class e passar por parâmetro o form
            funcionalidadesAplicacao.sair(this);
        }
    }

}
