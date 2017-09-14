using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        // GET: Jogador
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}