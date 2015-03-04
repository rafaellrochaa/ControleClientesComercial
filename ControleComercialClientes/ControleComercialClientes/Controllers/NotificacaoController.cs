using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleComercialClientes.Controllers
{
    public class NotificacaoController : Controller
    {
        //
        // GET: /Notificacao/

        public ActionResult Index()
        {
            //Lista de tipos itens a notificar (operadorItemChekList)
            return View();
        }

    }
}
