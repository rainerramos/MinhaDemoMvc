using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


//aprendemos a criar um prefixo exclusivo ou não para uma controller.
// aprendemos a complementar a rota atravpes das actions (posso ter uma rota vazia para cada controller)
// mas posso ter apenas uma rota vazia de controller para a aplicação toda,
// pq ele só pode redirecionar para uma controller quando ele não recebe nenhuma
// mas dentro da controller eu posso ter uma rota vazia para uma action a cada controller
// pq uma vez q ele encontra a controller, ele vai chamar aquele por padrão q estiver vazio

namespace MinhaDemoMvc.Controllers 
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {     
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]        
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categorias)
        {           
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
