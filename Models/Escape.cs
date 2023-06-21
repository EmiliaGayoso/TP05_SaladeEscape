class Escape{
public static string[] IncognitasSalas{get;set;}
public static int EstadoJuego{get;set;}
public static void InicializarJuego()
{
    IncognitasSalas=new string[]{"<!-","Y4NI","341","2210"};
}
public static int GetEstadoJuego()
{
    return EstadoJuego;
}
public static void CambioEstado()
{
    EstadoJuego++;
}
public static bool ResolverSala(int sala, string incognita)
{
  bool incPass=false;
    if(incognita == IncognitasSalas[sala])
    {
        incPass=true;
        EstadoJuego++;
    }
    return incPass;
}
}    