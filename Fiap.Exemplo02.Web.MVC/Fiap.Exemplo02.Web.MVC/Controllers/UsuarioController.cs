using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.Web.MVC.Models;

namespace Fiap.Exemplo02.Web.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        //Abrir a página de cadastro
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Receber as informações do formulário
        [HttpPost]
        public ActionResult Cadastro(Usuario usuario)
        {
            TempData["msg"] = "Usuário cadastrado!";
            ViewBag.mensagem = "Funciona!";
            return View("Sucesso", usuario);
        }
    }
}