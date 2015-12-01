using operacoesCRUD.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace operacoesCRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {    
        private DAO d;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DAO();
         
        }

        /* Buscar */
        protected void Button1_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            TipoDePessoa tp = d.buscarTipoDePessoaPorCodigo(codigo);

            if (tp != null) {
                /* Encontrada */
                /* Mostrar os dados */
                lblMensagem.Text = "Tipo de pessoa encontrada!";
                txtDescricao.Text = tp.Descricao;
                txtSigla.Text = tp.Sigla;

                txtDescricao.Enabled = true;
                txtSigla.Enabled = true;
                txtCodigo.Enabled = false;

                btnBuscar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCriar.Enabled = false;
            }
            else {
                /* Não encontrada */
                lblMensagem.Text = "Tipo de pessoa não encontrada!";
                txtDescricao.Enabled = true;
                txtSigla.Enabled = true;
                txtCodigo.Enabled = false;

                btnBuscar.Enabled = false;
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCriar.Enabled = true;
                
            }

        }

        protected void btnCriar_Click(object sender, EventArgs e)
        {
            TipoDePessoa tp = new TipoDePessoa();

            tp.Codigo = txtCodigo.Text;
            tp.Descricao = txtDescricao.Text;
            tp.Sigla = txtSigla.Text;

            d.criarTipoDePessoa(tp);
           
            voltarNormalidade();
            lblMensagem.Text = "Tipo de pessoa criada!";
            atualizarGridView();
           
        }

        private void atualizarGridView()
        {
            grdViewTipoPessoa.DataBind();
            SqlDataSource2.DataBind();          
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            TipoDePessoa tp = new TipoDePessoa();

            tp.Codigo = txtCodigo.Text;
            tp.Descricao = txtDescricao.Text;
            tp.Sigla = txtSigla.Text;

            d.atualizarTipoDePessoa(tp);
                
            voltarNormalidade();
            lblMensagem.Text = "Tipo de pessoa atualizada!";
            atualizarGridView();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            d.excluirTipoDePessoa(codigo);          

            voltarNormalidade();
            lblMensagem.Text = "Tipo de pessoa excluída!";
            atualizarGridView();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            voltarNormalidade();
            atualizarGridView();
        }

        private void voltarNormalidade() {

            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtSigla.Text = "";

            btnBuscar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCriar.Enabled = false;

            txtDescricao.Enabled = false;
            txtSigla.Enabled = false;
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
            lblMensagem.Text = "";
        }

        protected void DataSourceDeTodosOsTiposDePessoas_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

    }
}