using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class Calculadora : Controller
{
    private readonly ILogger<HomeController> _logger;

    public Calculadora(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Calcular()
    {
        return View();
    }

    public IActionResult Resultado([FromForm] double number1, [FromForm] double number2, [FromForm] int operation)
    {
        ViewData["number1"] = number1;
        ViewData["number2"] = number2;

        if (operation == 1)
        {
            ViewData["result"] = number1 + number2;
            ViewData["operation"] = "+";
        }
        else if (operation == 2)
        {
            ViewData["result"] = number1 - number2;
            ViewData["operation"] = "-";
        }
        else if (operation == 3)
        {
            ViewData["result"] = number1 / number2;
            ViewData["operation"] = "/";
        }
        else if (operation == 4)
        {
            ViewData["result"] = number1 * number2;
            ViewData["operation"] = "*";
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
