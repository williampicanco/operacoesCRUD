using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace operacoesCRUD.modelo
{
    public class Conexao
    {
        public SqlConnection con;
        public SqlCommand sen;
        public SqlDataReader rs;

        public Conexao(){
            con = new SqlConnection(@"server = .\sqlexpress;
                Database = empresa;
                integrated security = true;");
        }          
    }
}
