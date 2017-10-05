using Fiap.Revisao.Models;
using Fiap.Revisao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.App_Data
{
    public class ClienteController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();
        
        
        // GET: Cliente
        [HttpGet]      
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _unit.ClienteRepository.Cadastrar(cliente);
            _unit.Save();
            TempData["msg"] = "Cliente cadastrado com sucesso";
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {

            return View(_unit.ClienteRepository.Listar());
        }

        public ActionResult Action()
        {
            return View();
        }
    }
}