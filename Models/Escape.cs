class Escape{
public static string[] IncognitasSalas{get;set;}
public static int EstadoJuego{get;set;}
static public int intentos = 0;

private static void InicializarJuego()
{
    IncognitasSalas=new string[]{"<!-","Y4NI","341","2210"};
}
public static int GetEstadoJuego()
{
    return EstadoJuego;
}
public static bool ResolverSala(int sala, string incognita)
{
  if(IncognitasSalas == null) InicializarJuego();
        if(EstadoJuego == sala){
            if(incognita == IncognitasSalas[sala-1]){
                EstadoJuego++;
                return true;
            }
            intentos++;
        }
        return false;
    }    

}