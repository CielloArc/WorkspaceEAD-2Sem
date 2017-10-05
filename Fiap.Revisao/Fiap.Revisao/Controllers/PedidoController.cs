using Fiap.Revisao.Models;
using Fiap.Revisao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.Controllers
{
    public class PedidoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        // GET: Pedido
        public ActionResult Cadastrar()
        {
            var lista = _unit.ClienteRepository.Listar();
            ViewBag.clientes = new SelectList(lista, "ClienteId", "Nome");
            return View();
        }


        [HttpPost]
        public ActionResult Cadastrar(Pedido pedido)
        {
            _unit.PedidoRepository.Cadastrar(pedido);
            _unit.Save();
            TempData["msg"] = "Pedido cadastrado com sucesso";
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            return View(_unit.PedidoRepository.Listar());
        }
    }
}