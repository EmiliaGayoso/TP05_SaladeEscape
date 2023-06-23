class Escape{
public static string[] IncognitasSalas{get;set;}
public static int EstadoJuego{get;set;}
public static void InicializarJuego()
{
    IncognitasSalas=new string[]{"<!-","Y4NI","341","2210"};
    EstadoJuego = 1;
}
public static int GetEstadoJuego()
{
    return EstadoJuego;
}

public static bool ResolverSala(int sala, string incognita)
{
    if(sala==1)
    {
        InicializarJuego();
    }
    if(incognita == IncognitasSalas[sala-1])
    {
        EstadoJuego++;
        return true;
    }
    else{
        return false;
    }
    
}
}    