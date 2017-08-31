using Fiap.Exemplo03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostadorController : Controller
    {

        private LoteriaContext _context = new LoteriaContext();

        public ActionResult Remover(int id)
        {
            var apostador = _context.Apostadores.Find(id);
            _context.Apostadores.Remove(apostador);
            _context.SaveChanges();
            TempData["msg"] = "Removido";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Alterar(Apostador apostador)
        {
            _context.Entry(apostador).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado com sucesso";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_context.Apostadores.Find(id));
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Apostadores.ToList());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Apostador apostador)
        {
            _context.Apostadores.Add(apostador);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

    }
}