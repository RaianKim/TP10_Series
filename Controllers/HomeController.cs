using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

            //VerDetalleTemporadas
            //VerDetalleActores
            //VerDetalleMasInfo
    public IActionResult Index()
    {
        ViewBag.series = BD.ListarSeries();
        return View();
    }

    public Temporadas VerDetalleTemporadas(int IdSerie)
    {
        ViewBag.temp = BD.VerDetalleTemporadas(IdSerie);
        return ViewBag.temp;
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
