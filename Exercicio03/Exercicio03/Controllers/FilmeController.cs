using Exercicio03.Models;
using Exercicio03.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio03.Controllers
{
    public class FilmeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();


        // GET: Filme
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                _unit.FilmeRepository.Cadastrar(filme);
                _unit.Save();
                TempData["msg"] = "Filme Cadastrado com sucesso";
                return RedirectToAction("Listar");
            }
            else {
                return View(filme);
            }
        }

        public ActionResult Listar()
        {
            return View(_unit.FilmeRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}