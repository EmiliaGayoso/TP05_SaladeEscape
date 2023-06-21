using Microsoft.AspNetCore.Mvc;

namespace TP05_SaladeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Escape.InicializarJuego();
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        int habitacion = Escape.GetEstadoJuego()+1;
        Escape.CambioEstado();
        return View("habitacion"+ habitacion);
    }
    public IActionResult Creditos()
    {
        return View("Creditos");
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        Escape.InicializarJuego();
        if (sala != Escape.GetEstadoJuego())
        {
            return View("Habitacion"+Escape.GetEstadoJuego());
        }
        
        if (Escape.ResolverSala(sala, clave))
        {
            if(sala<=4)
            {
                return RedirectToAction("Comenzar");
            }
            else
            {
                return View("Victoria");
            }
        }
        else
        {
            ViewBag.Error= "RESPUESTA INCORRECTA";
            return View("Habitacion" + sala);
        }

    }
}