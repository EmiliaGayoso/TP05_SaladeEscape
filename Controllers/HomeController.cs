using Microsoft.AspNetCore.Mvc;

namespace TP05_SaladeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("tutorial");
    }
    public IActionResult Comenzar()
    {
       int habitacion=+ Escape.GetEstadoJuego();
       return View("habitacion1");
    }
    public IActionResult Creditos()
    {
        return View("creditos");
    }

    

    public IActionResult Habitacion(int sala, string clave)
    {
        if(!Escape.ResolverSala(sala,clave))
        {
            return View(Escape.GetEstadoJuego());
        }
        else
        {
            if(clave==Escape.IncognitasSalas[sala])
            {
                if(sala==5)
                {
                    return View("Victoria");
                }
                else
                {
                    return RedirectToAction("Comenzar");
                }
                
            }
            else
            {
                ViewBag.Error="⚠️RESPUESTA INCORRECTA⚠️";
                return View("Habitacion"+sala);
            }
            
        }

    }
}
