using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.Web.MVC.Models;

namespace Fiap.Exemplo02.Web.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> banco = new List<Produto>();

        // GET: Produto
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            banco.Add(produto);
            TempData["msg"] = "Produto cadastrado!";
            ViewBag.mensagem = "Gravado!";

            return View();            
        }

        public ActionResult Listar()
        {
            return View(banco);
        }
    }
}