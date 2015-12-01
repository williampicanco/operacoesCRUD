using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace operacoesCRUD.modelo
{
    public class DAO
    {
        private Conexao c;

        public DAO() {
            c = new Conexao();   
        }

        /* C.R.U.D */
        /* Create */
        public void criarTipoDePessoa(TipoDePessoa tp) {
            /* insert */
            String insert = "insert into tipo_de_pessoa values('"+tp.Codigo +"','"+tp.Descricao+"','"+tp.Sigla+"') ";
            executar(insert);
        }
        /* Read */
        public TipoDePessoa buscarTipoDePessoaPorCodigo(String codigo) {
            TipoDePessoa tp = null; //new TipoDePessoa();
            /* Select */

            /*ExecuteReader() --> que retorna um SQLDataReader --> c.rs*/
            String select = "select * from tipo_de_pessoa where codigo = '"+codigo+"' ";

            c.con.Open();
            c.sen = new SqlCommand(select, c.con);

            c.rs = c.sen.ExecuteReader();

            if(c.rs.Read())
            {
                tp = new TipoDePessoa();
                tp.Codigo = c.rs.GetString(0);// "0" é a posição na tabela do código, por exemplo.
                tp.Descricao = c.rs.GetString(1);
                tp.Sigla = c.rs.GetString(2);
            }
       
            c.con.Close();
            return tp;
        }
        /* Update */
        public void atualizarTipoDePessoa(TipoDePessoa tp) {
            /* Update */
            String update = "update tipo_de_pessoa set descricao = '"+tp.Descricao +"', sigla = '"+tp.Sigla+"'where codigo = '"+tp.Codigo+"'";
            executar(update);
        }
        /* Delete */
        public void excluirTipoDePessoa(String codigo) {
            /* Delete */
            String delete = "delete from tipo_de_pessoa where codigo ='" + codigo + "' ";
            executar(delete);
        }
        /* Método que executa algo em comum e pode ser um: Insert, Update ou Delete */
        private void executar(String consultaSQL) {
            c.con.Open();
            c.sen = new SqlCommand(consultaSQL, c.con);
            c.sen.ExecuteNonQuery();
            c.con.Close();
        }
    }
}