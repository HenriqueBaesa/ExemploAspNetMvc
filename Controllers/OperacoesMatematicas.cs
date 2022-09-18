using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class OperacoesMatematicas : Controller
{
    private readonly ILogger<HomeController> _logger;

    public OperacoesMatematicas(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult ResultadoSomar([FromForm] double number1, [FromForm] double number2)
    {
        ViewData["number1"] = number1;
        ViewData["number2"] = number2;
        ViewData["result"] = number1 + number2;

        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult ResultadoSubtrair([FromForm] double number1, [FromForm] double number2)
    {
        ViewData["number1"] = number1;
        ViewData["number2"] = number2;
        ViewData["result"] = number1 - number2;

        return View();
    }


    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult ResultadoMultiplicar([FromForm] double number1, [FromForm] double number2)
    {
        ViewData["number1"] = number1;
        ViewData["number2"] = number2;
        ViewData["result"] = number1 * number2;

        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoDividir([FromForm] double number1, [FromForm] double number2)
    {
        ViewData["number1"] = number1;
        ViewData["number2"] = number2;
        ViewData["result"] = number1 / number2;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
