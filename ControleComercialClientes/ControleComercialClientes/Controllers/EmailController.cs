using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleComercialClientes.Models;

namespace ControleComercialClientes.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmail _notif;

        public EmailController(IEmail notif)
        {
            _notif = notif;
        }
        public ActionResult Index()
        {
            _notif.Assunto = "Sou foda";
            _notif.TextoCorpoEmail = "Chupa funcionou!!";
            _notif.Destinatario = "rafael@agilus.com.br";

            new NotificacaoPorEmail(_notif).DispararNotificacao();
            return View(_notif);
        }
    }
}
