using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleComercialClientes.Models
{
    public class Email : IEmail
    {
        public Email()
        {
            porta = 587;
        }

        public Email(int PortaAlternativa)
        {
            porta = PortaAlternativa;
        }

        //Informações para logar no email
        private const string usuario = "rafael@agilus.com.br";
        private const string senha = "ac@78902";
        private const string dominio = "smtp.agilus.com.br";
        private int porta { get; set; }

        //Propriedades públicas
        public string Destinatario { get; set; }
        public List<string> Copia { get; set; }
        public List<string> CopiaOculta { get; set; }
        public string Assunto { get; set; }
        public string TextoCorpoEmail { get; set; }
        public string Remetente { get { return usuario; } }
        
        public System.Net.Mail.SmtpClient LogarEmail
        {
            get
            {
                return Logar();
            }
        }

        private System.Net.Mail.SmtpClient Logar()
        {
            System.Net.Mail.SmtpClient conectaEmail = new System.Net.Mail.SmtpClient();
            conectaEmail.Credentials = new System.Net.NetworkCredential(usuario, senha);
            conectaEmail.Host = dominio;
            conectaEmail.Port = porta;
            return conectaEmail;
        }
    }
}