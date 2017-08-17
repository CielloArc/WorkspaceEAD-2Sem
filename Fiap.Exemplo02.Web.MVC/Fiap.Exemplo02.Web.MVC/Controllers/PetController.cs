using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.Web.MVC.Models;

namespace Fiap.Exemplo02.Web.MVC.Controllers
{
    public class PetController : Controller
    {
        private static List<Pet> banco = new List<Pet>();

        // GET: Pet
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Cadastro(Pet pet)
        {
            banco.Add(pet);
            TempData["msg"] = "Pet cadastrado!";
            ViewBag.mensagem = "Gravado!";

            return View();
        }

        public ActionResult Listar()
        {            
            return View(banco);
        }
    }
}