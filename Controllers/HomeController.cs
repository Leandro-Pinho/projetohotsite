using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            if (cad.Nome == null && cad.Email != null)
            {
                try
                {
                    dbs.CadastraInteresse(cad);
                    ViewData["Mensagem"] = "Cadastro realizado com sucesso!";
                }
                catch(Exception e)
                {
                    _logger.LogError("Falha no cadastro: " + e.Message);
                }
            } 
            else 
            {
                ViewData["Mensagem"] = "Falha no cadastro! Preencha os campos obrigatorios.";
                _logger.LogWarning("esta errado");
            }
           
            return View("Index",cad);
        }

    }
}
