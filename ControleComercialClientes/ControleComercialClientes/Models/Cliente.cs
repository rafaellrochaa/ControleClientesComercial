using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleComercialClientes.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string EmailResponsavel { get; set; }
        public string NomeContatoEmpresa { get; set; }
        public double TxDesconto { get; set; } //Se houver desconto, pode ser por uma taxa... Haverá um método que implementará o cálculo.
        public double ValorMensalidade { get; set; }
        public double ValorImplantacao { get; set; }
        public double ValorDesconto { get; set; } //Se houver desconto, pode ser setado um valor direto, a ser descontado da implantacao ou mensalidade
        public CheckList CheckList { get; set; }
    }
}