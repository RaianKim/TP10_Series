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

    public List<Temporadas> VerDetalleTemporadas(int IdSerie)
    {
        return BD.VerDetalleTemporadas(IdSerie);
    }

    public Series VerDetalleSinopsis(int IdSerie)
    {
        return BD.VerDetalleSinopsis(IdSerie);
    }
    public List<Actores> VerDetalleActores(int IdSerie)
    {
        return BD.VerDetalleActores(IdSerie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
