using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComercialClientes.Models
{
    public interface IEmail
    {
        new System.Net.Mail.SmtpClient LogarEmail { get; }
        string Remetente { get;}
        string Destinatario { get; set; }
        List<string> Copia { get; set; }
        List<string> CopiaOculta { get; set; }
        string Assunto { get; set; }
        string TextoCorpoEmail { get; set; }
    }
}
