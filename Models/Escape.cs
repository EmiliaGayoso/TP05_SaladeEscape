class Escape{
public static string[] IncognitasSalas{get;set;}
public static int EstadoJuego{get;set;}

private static void InicializarJuego()
{
IncognitasSalas=new string[]{"bitch","slut","lara","byebye"};
}
public static int GetEstadoJuego()
{
    return EstadoJuego;
}
public static bool ResolverSala(int sala, string incognita)
{
    bool incPass=false;
    if(IncognitasSalas[sala]==incognita)
    {
        incPass=true;
        EstadoJuego++;
    }
    return incPass;
}

}