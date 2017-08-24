using Fiap.Exemplo3.Web.MVC.Models;
using Fiap.Exemplo3.Web.MVC.Models.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo3.Web.MVC.Controllers
{
    public class LoteriaController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Apostador apostador)
        {
            var context = new LoteriaContext();
            string msg;

            try
            {
                context.Apostadores.Add(apostador);
                context.SaveChanges();
                msg = "Cadastrado com sucesso";
            }
            catch (Exception e)
            {                
                msg = "Erro ao Cadastrar";
                throw new Exception(msg);
            }

            TempData["msg"] = msg;
            ViewBag.message = "Ação concluida!";

            return RedirectToAction("Cadastrar");
        }
    }
}