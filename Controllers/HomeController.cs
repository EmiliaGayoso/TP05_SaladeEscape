using Microsoft.AspNetCore.Mvc;

namespace TP05_SaladeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Escape.EstadoJuego=0;
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        if (Escape.GetEstadoJuego() == 0)
        {
            Escape.InicializarJuego();
        }
        int habitacion = Escape.GetEstadoJuego();
        return View("habitacion" + habitacion);
    }
    public IActionResult Creditos()
    {
        return View("Creditos");
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if (sala != Escape.GetEstadoJuego())
        {
            System.Console.WriteLine(sala);
            System.Console.WriteLine(Escape.GetEstadoJuego());
            System.Console.WriteLine(clave);
            return View("Habitacion" + Escape.GetEstadoJuego());
        }
        bool resuelto = Escape.ResolverSala(sala, clave);
        if (resuelto == true)
        {
            if (sala < 4)
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
            Console.WriteLine("ERROR");
            ViewBag.Error = "RESPUESTA INCORRECTA";
            return View("Habitacion" + sala);
        }

    }
}