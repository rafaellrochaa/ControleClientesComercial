using ControleComercialClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleComercialClientes.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /ChamaHome/

        public ActionResult Index()
        {
            //NotificacaoPorEmail n = new NotificacaoPorEmail(new Email("rafael@agilus.com.br", "ac@78902", "smtp.agilus.com.br") { Destinatario = "rafael@agilus.com.br", Assunto = "Teste Program" });
            //n.DispararNotificacao();

            return RedirectToAction("Index", "Email", new Email());
        }

    }
}
