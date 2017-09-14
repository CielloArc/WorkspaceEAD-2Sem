using Fiap.Exemplo04.Web.MVC.Models;
using Fiap.Exemplo04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.Web.MVC.Controllers
{
    public class TimeController : Controller
    {
        private FutebolContext context = new FutebolContext();

        // GET: Time
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            context.Times.Add(time);
            context.SaveChanges();
            TempData["msg"] = "Time cadastrado com sucesso";
            return RedirectToAction ("Cadastrar");
        }

        public ActionResult Listar()
        {
            return View(context.Times.Include("Tecnico").ToList());
        }


    }
}