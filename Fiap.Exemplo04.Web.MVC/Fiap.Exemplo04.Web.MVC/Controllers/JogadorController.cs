using Fiap.Exemplo04.Web.MVC.Models;
using Fiap.Exemplo04.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Fiap.Exemplo04.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _unit.JogadorRepository.Cadastrar(jogador);
                _unit.Save();
                TempData["msg"] = "Cadastrado com sucessso";
                return View(_unit.JogadorRepository.Listar());
            }
            else
            {
                var lista = _unit.TimeRepository.Listar();
                ViewBag.times = new SelectList(lista, "TimeId", "Nome");
                return View(_unit.JogadorRepository.Listar());
            }
        }


        
        public ActionResult Listar()
        {
            return View(_unit.JogadorRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}