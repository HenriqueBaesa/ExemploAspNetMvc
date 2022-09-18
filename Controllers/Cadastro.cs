using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class Cadastro : Controller
{
    private readonly ILogger<HomeController> _logger;

    public Cadastro(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

    public IActionResult Cadastramento([FromForm] string nome, [FromForm] string email, [FromForm] string senha)
    {
        var usuario = new User(nome, senha, email);
        return Content("Cadastrado com sucesso!");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
