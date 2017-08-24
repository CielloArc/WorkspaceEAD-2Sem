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
            
            List<string> especies = new List<string>();
            especies.Add("Cachorro");
            especies.Add("Gato");
            especies.Add("Ave");
            especies.Add("Réptil");
            especies.Add("Peixe");
            especies.Add("Outro");
            ViewBag.opcoes = new SelectList(especies);
            return View();

        }


        [HttpPost]
        public ActionResult Cadastro(Pet pet)
        {
            banco.Add(pet);
            TempData["msg"] = "Pet cadastrado!";
            ViewBag.mensagem = "Gravado!";
            //return View();
            return RedirectToAction("Cadastro");
        }

        public ActionResult Listar()
        {            
            return View(banco);
        }
    }
}