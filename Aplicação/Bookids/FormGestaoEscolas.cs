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
    public partial class FormGestaoEscolas : Form
    {
        Escolas escola = new Escolas();
        funcionalidadesAplicacao funcionalidadesAplicacao = new funcionalidadesAplicacao();
        public FormGestaoEscolas()
        {
            InitializeComponent();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            funcionalidadesAplicacao.ajuda(this);
        }

        private void FormGestaoEscolas_Load(object sender, EventArgs e)
        {
            //preencher o adaptador da tabela com os dados da classe
            this.escolasSetTableAdapter.Fill(this.bdBookidsDataSet2.EscolasSet);
            limpar();
            tabelaEscolas.ClearSelection();

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

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = funcionalidadesAplicacao.getDataHora();
        }

        private void txtTelefoneEscola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnInserirEscola_Click(object sender, EventArgs e)
        {
            if (validarCaixasDeTexto() == false)
            {
                DialogResult result = MessageBox.Show("É obrigatório preencher corretamente as caixas de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                {
                    escola.CodPostal = txtCodPostalEscola.Text;
                    escola.Nome = txtNomeEscola.Text;
                    escola.Localidade = txtLocalidadeEscola.Text;
                    escola.Mail = txtMailEscola.Text;
                    escola.Telefone = txtTelefoneEscola.Text;
                    escola.Morada = txtMoradaEscola.Text;
                    //adicinar a classe a nova escola
                    db.EscolasSet.Add(escola);
                    db.SaveChanges();
                    limpar();
                    DialogResult result = MessageBox.Show("Escola inserida com sucesso!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                atualizarAdaptadorTabela();
                tabelaEscolas.ClearSelection();
                limpar();
            }
        }
        private void limpar()
        {
            txtCodPostalEscola.Text = "";
            txtLocalidadeEscola.Text = "";
            txtMailEscola.Text = "";
            txtMoradaEscola.Text = "";
            txtNomeEscola.Text = "";
            txtTelefoneEscola.Text = "";
        }
        private void atualizarAdaptadorTabela()
        {
            //resetar a data set 
            this.bdBookidsDataSet2.Reset();
            //preencher o adaptador da tabela
            this.escolasSetTableAdapter.Fill(bdBookidsDataSet2.EscolasSet);
        }

        private void btnAlterarEscola_Click(object sender, EventArgs e)
        {
            //testar se existe alguma linha selecionada
            if (tabelaEscolas.SelectedRows.Count > 0)
            {
                if(validarCaixasDeTexto() == false)
                {
                    DialogResult result = MessageBox.Show("É obrigatório preencher corretamente as caixas de texto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //alterar registo
                        escola.IdEscola = Convert.ToInt32(tabelaEscolas.CurrentRow.Cells["idEscolaDataGridViewTextBoxColumn"].Value);
                        escola.Nome = txtNomeEscola.Text.Trim();
                        escola.Localidade = txtLocalidadeEscola.Text.Trim();
                        escola.Mail = txtMailEscola.Text.Trim();
                        escola.Telefone = txtTelefoneEscola.Text.Trim();
                        escola.Morada = txtMoradaEscola.Text.Trim();
                        escola.CodPostal = txtCodPostalEscola.Text.Trim();
                        db.Entry(escola).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        limpar();
                        DialogResult result = MessageBox.Show("Escola alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        atualizarAdaptadorTabela();
                        tabelaEscolas.ClearSelection();
                    }
                }            
            }
            else
            {
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tabelaEscolas_Click(object sender, EventArgs e)
        {
            if (tabelaEscolas.SelectedRows.Count > 0)
            {
                //passar o codigo da linha selecionada para o atributo
                escola.IdEscola = Convert.ToInt32(tabelaEscolas.CurrentRow.Cells["idEscolaDataGridViewTextBoxColumn"].Value);
                using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                {
                    //criar objetos com os dados da linha selecionada
                    escola = db.EscolasSet.Where(x => x.IdEscola == escola.IdEscola).FirstOrDefault();
                    txtCodPostalEscola.Text = escola.CodPostal;
                    txtLocalidadeEscola.Text = escola.Localidade;
                    txtMailEscola.Text = escola.Mail;
                    txtTelefoneEscola.Text = escola.Telefone;
                    txtNomeEscola.Text = escola.Nome;
                    txtMoradaEscola.Text = escola.Morada;
                }
            }
        }

        private void btnEliminarEscola_Click(object sender, EventArgs e)
        {
            if (tabelaEscolas.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja eliminar a escola " + escola.IdEscola + " - " + escola.Nome + "?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //buscar objeto que corresponde ao codigo selecionado     
                    using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                    {
                        //encontrar objeto que corresponde ao codigo 
                        escola = db.EscolasSet.Where(x => x.IdEscola == escola.IdEscola).FirstOrDefault();
                    }
                    try
                    {
                        using (ModeloBookidsContainer db = new ModeloBookidsContainer())
                        {
                            db.EscolasSet.Attach(escola);
                            db.EscolasSet.Remove(escola);
                            db.SaveChanges();

                            DialogResult result = MessageBox.Show("Escola eliminada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não é possível eliminar a escola ...!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                atualizarAdaptadorTabela();
                tabelaEscolas.ClearSelection();
                limpar();
            }
            else
            {
                DialogResult result = MessageBox.Show("É obrigatório selecionar a linha do registo na tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool validarCaixasDeTexto()
        {
            if (txtNomeEscola.Text.Trim() == "" || txtLocalidadeEscola.Text.Trim() == "" || txtMailEscola.Text.Trim() == "" ||
                txtTelefoneEscola.Text.Trim() == "" || txtMoradaEscola.Text.Trim() == "" || txtCodPostalEscola.Text.Trim().Length < 8 || txtTelefoneEscola.Text.Trim().Length < 9)
            {
                return false;
            }
            return true;
        }
    }
}
