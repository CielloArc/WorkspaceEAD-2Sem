using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Fiap.Exemplo03.Web.MVC.Models;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostaController : Controller
    {
        private LoteriaContext _context = new LoteriaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aposta aposta)
        {
            _context.Apostas.Add(aposta);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Apostas.ToList());
        }        
        
        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_context.Apostas.Find(id));
        }

        public ActionResult Alterar(Aposta aposta)
        {
            _context.Entry(aposta).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Aposta alterada com sucesso!";
            return RedirectToAction("Listar");
        }

        public ActionResult Remover(int id)
        {
            var aposta = _context.Apostas.Find(id);
            _context.Apostas.Remove(aposta);
            _context.SaveChanges();
            TempData["msg"] = "Aposta removida!";
            return RedirectToAction("Listar");            
        }


    }
}