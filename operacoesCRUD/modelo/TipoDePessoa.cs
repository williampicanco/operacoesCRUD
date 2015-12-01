using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace operacoesCRUD.modelo
{
    public class TipoDePessoa
    {
        private String codigo;
        private String descricao;
        private String sigla;

        public String Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public String Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public String Sigla
        {
            get
            {
                return sigla;
            }

            set
            {
                sigla = value;
            }
        }
    }
}