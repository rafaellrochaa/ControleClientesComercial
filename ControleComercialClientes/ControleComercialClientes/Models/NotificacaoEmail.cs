using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ControleComercialClientes.Models
{
    public class NotificacaoPorEmail : INotificacaoEmail
    {
        readonly IEmail _notif;

        public NotificacaoPorEmail(IEmail notif)
        {
            _notif = notif;
        }

        public void DispararNotificacao()
        {
            MailMessage objEmail = new MailMessage();
            objEmail.From = new System.Net.Mail.MailAddress(this._notif.Remetente);
            objEmail.To.Add(this._notif.Destinatario);
            if (_notif.Copia != null)
            {
                foreach (var cc in _notif.Copia)
                {
                    objEmail.CC.Add(cc);
                }
            }
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;
            objEmail.IsBodyHtml = true;
            objEmail.Subject = this._notif.Assunto;
            objEmail.Body = this._notif.TextoCorpoEmail;

            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

            try
            {
                _notif.LogarEmail.Send(objEmail);
            }

            catch (Exception ex)
            {
                throw new Exception("Ocorreram problemas no envio do e-mail. Erro = " + ex.Message);
            }

            finally
            {
                objEmail.Dispose();
            }
        }
    }
}