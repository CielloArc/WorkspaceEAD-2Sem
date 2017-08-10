using Fiap.Exemplo01.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.Web.MVC.Controllers
{
    public class FuncionarioController : Controller
    {        
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gravar(Funcionario func)
        {
            //Passar os valores para tela
            ViewBag.nome = func.Nome;
            ViewBag.dataNasc = func.Data;
            ViewBag.sal = func.Salario;
            //Passa o objeto para a view
            return View(func);
        }
    }
}