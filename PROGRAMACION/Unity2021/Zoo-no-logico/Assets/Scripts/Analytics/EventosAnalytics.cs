using System.Collections;
using Unity.Services.Core;
using Unity.Services.Analytics;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core.Environments;

public class EventosAnalytics : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update
    async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            List<string> consentIdentifiers = await AnalyticsService.Instance.CheckForRequiredConsents();
        }
        catch (ConsentCheckException e)
        {
            // Something went wrong when checking the GeoIP, check the e.Reason and handle appropriately.
        }
    }

    public void game_over()
    {
        AnalyticsService.Instance.CustomData("game_over", new Dictionary<string, object>(){
            {"dinero", PlayerPrefs.GetInt("Moneditas")},
            {"cruzas_exitosas", PlayerPrefs.GetInt("cruzasExito")},
            {"cruzas_fallidas", PlayerPrefs.GetInt("cruzasFalla")},
            {"tiempo_juego", PlayerPrefs.GetInt("TiempoJuego")},
            {"cruzas", PlayerPrefs.GetInt("totalCodex")},
            {"cupos", PlayerPrefs.GetInt("JaulasOcupadas")},
            {"dias", PlayerPrefs.GetInt("Dias")},
            {"animales_stasis_total", PlayerPrefs.GetInt("totalStasis")},
            {"animales_stasis_cantidad", PlayerPrefs.GetInt("CantidadCruzasEnStasis")},
            {"animales_lazaro", PlayerPrefs.GetInt("totalVendidos")},
            {"cartas", PlayerPrefs.GetInt("cartasTotales")},
            
            {"logro0", PlayerPrefs.GetInt("Logro0")},
            {"logro1", PlayerPrefs.GetInt("Logro1")},
            {"logro2", PlayerPrefs.GetInt("Logro2")},
            {"logro3", PlayerPrefs.GetInt("Logro3")},
            {"logro4", PlayerPrefs.GetInt("Logro4")},
            {"logro5", PlayerPrefs.GetInt("Logro5")},
            {"logro6", PlayerPrefs.GetInt("Logro6")},
            {"logro7", PlayerPrefs.GetInt("Logro7")},
            {"logro8", PlayerPrefs.GetInt("Logro8")},
            {"logro9", PlayerPrefs.GetInt("Logro9")},
            {"logro10", PlayerPrefs.GetInt("Logro10")},
            {"logro11", PlayerPrefs.GetInt("Logro11")},
            {"logro12", PlayerPrefs.GetInt("Logro12")},
            {"logro13", PlayerPrefs.GetInt("Logro13")},
            {"logro14", PlayerPrefs.GetInt("Logro14")},
            {"logro15", PlayerPrefs.GetInt("Logro15")},
            {"logro16", PlayerPrefs.GetInt("Logro16")},
            {"logro17", PlayerPrefs.GetInt("Logro17")},
            {"logro18", PlayerPrefs.GetInt("Logro18")},
            {"logro19", PlayerPrefs.GetInt("Logro19")},
            {"logro20", PlayerPrefs.GetInt("Logro20")},
            {"logro21", PlayerPrefs.GetInt("Logro21")},
            {"logro22", PlayerPrefs.GetInt("Logro22")},
            {"logro23", PlayerPrefs.GetInt("Logro23")},
            {"logro24", PlayerPrefs.GetInt("Logro24")},
            {"logro25", PlayerPrefs.GetInt("Logro25")},
            {"logro26", PlayerPrefs.GetInt("Logro26")},
            {"logro27", PlayerPrefs.GetInt("Logro27")},
            {"logro28", PlayerPrefs.GetInt("Logro28")},
        });  //TERMINADO

        Debug.Log("dinero " + PlayerPrefs.GetInt("Moneditas"));
        Debug.Log("cruzas_exitosas " + PlayerPrefs.GetInt("cruzasExito"));
        Debug.Log("cruzas_fallidas " + PlayerPrefs.GetInt("cruzasFalla"));
        Debug.Log("tiempo_juego " + PlayerPrefs.GetInt("TiempoJuego"));
        Debug.Log("cruzas " + PlayerPrefs.GetInt("totalCodex"));
        Debug.Log("cupos " + PlayerPrefs.GetInt("JaulasOcupadas"));
        Debug.Log("dias " + PlayerPrefs.GetInt("Dias"));
        Debug.Log("animales_stasis_total " + PlayerPrefs.GetInt("totalStasis"));
        Debug.Log("animales_stasis_cantidad " + PlayerPrefs.GetInt("CantidadCruzasEnStasis"));
        Debug.Log("animales_lazaro " + PlayerPrefs.GetInt("totalVendidos"));
        Debug.Log("cartas" + PlayerPrefs.GetInt("cartasTotales"));

        Debug.Log("logro0" + PlayerPrefs.GetInt("Logro0"));
    }

    public void comprar()
    {
        AnalyticsService.Instance.CustomData("comprar", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("vezCompra")},
            {"animal", PlayerPrefs.GetString("animalCompra")},
            {"cantidad_ave", PlayerPrefs.GetInt("AvesTotales")},
            {"cantidad_serpiente", PlayerPrefs.GetInt("SerpientesTotales")},
            {"cantidad_murcielago", PlayerPrefs.GetInt("MurcielagosTotales")},
            {"cantidad_zorro", PlayerPrefs.GetInt("ZorrosTotales")},
            {"cantidad_cocodrilo", PlayerPrefs.GetInt("CocodrilosTotales")},
            {"cantidad_arana", PlayerPrefs.GetInt("AranasTotales")},
            {"cantidad_carpincho", PlayerPrefs.GetInt("CarpinchosTotales")},

        });  //TERMINADO

        Debug.Log("vez" +  PlayerPrefs.GetInt("vezCompra"));
        Debug.Log("animal " + PlayerPrefs.GetString("animalCompra"));
        Debug.Log("cantidad_ave" + PlayerPrefs.GetInt("AvesTotales"));
        Debug.Log("cantidad_serpiente" + PlayerPrefs.GetInt("SerpientesTotales"));
        Debug.Log("cantidad_murcielago" + PlayerPrefs.GetInt("MurcielagosTotales"));
        Debug.Log("cantidad_zorro" + PlayerPrefs.GetInt("ZorrosTotales"));
        Debug.Log("cantidad_cocodrilo" + PlayerPrefs.GetInt("CocodrilosTotales"));
        Debug.Log("cantidad_arana" + PlayerPrefs.GetInt("AranasTotales"));
        Debug.Log("cantidad_carpincho" + PlayerPrefs.GetInt("CarpinchosTotales"));
    }

    public void cruza()
    {
        AnalyticsService.Instance.CustomData("cruza", new Dictionary<string, object>(){
            {"animal3", PlayerPrefs.GetString("animalSlot3")},
            {"animal2", PlayerPrefs.GetString("animalSlot2")},
            {"animal1", PlayerPrefs.GetString("animalSlot1")},
            {"numero_id", PlayerPrefs.GetInt("indexCurrentCruza")},
            {"vez", PlayerPrefs.GetInt("combinarTotales")},

        });  //TERMINADO

        Debug.Log("animal3" + PlayerPrefs.GetString("animalSlot3"));
        Debug.Log("animal2" + PlayerPrefs.GetString("animalSlot2"));
        Debug.Log("animal1" + PlayerPrefs.GetString("animalSlot1"));
        Debug.Log("numero_id" + PlayerPrefs.GetInt("indexCurrentCruza"));
        Debug.Log("vez" + PlayerPrefs.GetInt("combinarTotales"));
    }

    public void ganar()
    {
        AnalyticsService.Instance.CustomData("ganar", new Dictionary<string, object>(){
            {"tiempo_juego", PlayerPrefs.GetInt("TiempoJuego")},
            {"cruzas_fallidas", PlayerPrefs.GetInt("cruzasFalla")},
            {"cruzas_exitosas", PlayerPrefs.GetInt("cruzasExito")},
            {"cupos", PlayerPrefs.GetInt("JaulasOcupadas")},
            {"animales_lazaro", PlayerPrefs.GetInt("totalVendidos")},
            {"animales_stasis_total", PlayerPrefs.GetInt("totalStasis")},
            {"animales_stasis_cantidad", PlayerPrefs.GetInt("CantidadCruzasEnStasis")},
            {"dinero", PlayerPrefs.GetInt("Moneditas")},
            {"dias", PlayerPrefs.GetInt("Dias")},
            {"cartas", PlayerPrefs.GetInt("cartasTotales")},
            {"cruzas", PlayerPrefs.GetInt("totalCodex")},

            {"logro0", PlayerPrefs.GetInt("Logro0")},
            {"logro1", PlayerPrefs.GetInt("Logro1")},
            {"logro2", PlayerPrefs.GetInt("Logro2")},
            {"logro3", PlayerPrefs.GetInt("Logro3")},
            {"logro4", PlayerPrefs.GetInt("Logro4")},
            {"logro5", PlayerPrefs.GetInt("Logro5")},
            {"logro6", PlayerPrefs.GetInt("Logro6")},
            {"logro7", PlayerPrefs.GetInt("Logro7")},
            {"logro8", PlayerPrefs.GetInt("Logro8")},
            {"logro9", PlayerPrefs.GetInt("Logro9")},
            {"logro10", PlayerPrefs.GetInt("Logro10")},
            {"logro11", PlayerPrefs.GetInt("Logro11")},
            {"logro12", PlayerPrefs.GetInt("Logro12")},
            {"logro13", PlayerPrefs.GetInt("Logro13")},
            {"logro14", PlayerPrefs.GetInt("Logro14")},
            {"logro15", PlayerPrefs.GetInt("Logro15")},
            {"logro16", PlayerPrefs.GetInt("Logro16")},
            {"logro17", PlayerPrefs.GetInt("Logro17")},
            {"logro18", PlayerPrefs.GetInt("Logro18")},
            {"logro19", PlayerPrefs.GetInt("Logro19")},
            {"logro20", PlayerPrefs.GetInt("Logro20")},
            {"logro21", PlayerPrefs.GetInt("Logro21")},
            {"logro22", PlayerPrefs.GetInt("Logro22")},
            {"logro23", PlayerPrefs.GetInt("Logro23")},
            {"logro24", PlayerPrefs.GetInt("Logro24")},
            {"logro25", PlayerPrefs.GetInt("Logro25")},
            {"logro26", PlayerPrefs.GetInt("Logro26")},
            {"logro27", PlayerPrefs.GetInt("Logro27")},
            {"logro28", PlayerPrefs.GetInt("Logro28")},
        }); //TERMINADO

        Debug.Log("tiempo_juego" + PlayerPrefs.GetInt("TiempoJuego"));
        Debug.Log("cruzas_fallidas" + PlayerPrefs.GetInt("cruzasFalla"));
        Debug.Log("cruzas_exitosas" + PlayerPrefs.GetInt("cruzasExito"));
        Debug.Log("cupos" + PlayerPrefs.GetInt("JaulasOcupadas"));
        Debug.Log("animales_lazaro" + PlayerPrefs.GetInt("totalVendidos"));
        Debug.Log("animales_stasis_total" + PlayerPrefs.GetInt("totalStasis"));
        Debug.Log("animales_stasis_cantidad" + PlayerPrefs.GetInt("CantidadCruzasEnStasis"));
        Debug.Log("dinero" + PlayerPrefs.GetInt("Moneditas"));
        Debug.Log("dias" + PlayerPrefs.GetInt("Dias"));
        Debug.Log("cartas" + PlayerPrefs.GetInt("cartasTotales"));
        Debug.Log("cruzas" + PlayerPrefs.GetInt("totalCodex"));

        Debug.Log("logro0" + PlayerPrefs.GetInt("Logro0"));

    }

    public void salir()
    {
         AnalyticsService.Instance.CustomData("salir", new Dictionary<string, object>(){
            {"tiempo_juego", PlayerPrefs.GetInt("TiempoJuego")},
            {"cruzas_fallidas", PlayerPrefs.GetInt("cruzasFalla")},
            {"cruzas_exitosas", PlayerPrefs.GetInt("cruzasExito")},
            {"cupos", PlayerPrefs.GetInt("JaulasOcupadas")},
            {"animales_lazaro", PlayerPrefs.GetInt("totalVendidos")},
            {"animales_stasis_total", PlayerPrefs.GetInt("totalStasis")},
            {"animales_stasis_cantidad", PlayerPrefs.GetInt("CantidadCruzasEnStasis")},
            {"dinero", PlayerPrefs.GetInt("Moneditas")},
            {"dias", PlayerPrefs.GetInt("Dias")},
            {"cartas", PlayerPrefs.GetInt("cartasTotales")},
            {"cruzas", PlayerPrefs.GetInt("totalCodex")},

            {"logro0", PlayerPrefs.GetInt("Logro0")},
            {"logro1", PlayerPrefs.GetInt("Logro1")},
            {"logro2", PlayerPrefs.GetInt("Logro2")},
            {"logro3", PlayerPrefs.GetInt("Logro3")},
            {"logro4", PlayerPrefs.GetInt("Logro4")},
            {"logro5", PlayerPrefs.GetInt("Logro5")},
            {"logro6", PlayerPrefs.GetInt("Logro6")},
            {"logro7", PlayerPrefs.GetInt("Logro7")},
            {"logro8", PlayerPrefs.GetInt("Logro8")},
            {"logro9", PlayerPrefs.GetInt("Logro9")},
            {"logro10", PlayerPrefs.GetInt("Logro10")},
            {"logro11", PlayerPrefs.GetInt("Logro11")},
            {"logro12", PlayerPrefs.GetInt("Logro12")},
            {"logro13", PlayerPrefs.GetInt("Logro13")},
            {"logro14", PlayerPrefs.GetInt("Logro14")},
            {"logro15", PlayerPrefs.GetInt("Logro15")},
            {"logro16", PlayerPrefs.GetInt("Logro16")},
            {"logro17", PlayerPrefs.GetInt("Logro17")},
            {"logro18", PlayerPrefs.GetInt("Logro18")},
            {"logro19", PlayerPrefs.GetInt("Logro19")},
            {"logro20", PlayerPrefs.GetInt("Logro20")},
            {"logro21", PlayerPrefs.GetInt("Logro21")},
            {"logro22", PlayerPrefs.GetInt("Logro22")},
            {"logro23", PlayerPrefs.GetInt("Logro23")},
            {"logro24", PlayerPrefs.GetInt("Logro24")},
            {"logro25", PlayerPrefs.GetInt("Logro25")},
            {"logro26", PlayerPrefs.GetInt("Logro26")},
            {"logro27", PlayerPrefs.GetInt("Logro27")},
            {"logro28", PlayerPrefs.GetInt("Logro28")},
        }); //TERMINADO

        Debug.Log("tiempo_juego" + PlayerPrefs.GetInt("TiempoJuego"));
        Debug.Log("cruzas_fallidas" + PlayerPrefs.GetInt("cruzasFalla"));
        Debug.Log("cruzas_exitosas" + PlayerPrefs.GetInt("cruzasExito"));
        Debug.Log("cupos" + PlayerPrefs.GetInt("JaulasOcupadas"));
        Debug.Log("animales_lazaro" + PlayerPrefs.GetInt("totalVendidos"));
        Debug.Log("animales_stasis_total" + PlayerPrefs.GetInt("totalStasis"));
        Debug.Log("animales_stasis_cantidad" + PlayerPrefs.GetInt("CantidadCruzasEnStasis"));
        Debug.Log("dinero" + PlayerPrefs.GetInt("Moneditas"));
        Debug.Log("dias" + PlayerPrefs.GetInt("Dias"));
        Debug.Log("cartas" + PlayerPrefs.GetInt("cartasTotales"));
        Debug.Log("cruzas" + PlayerPrefs.GetInt("totalCodex"));
    }

    public void iniciar_partida()
    {
        AnalyticsService.Instance.CustomData("iniciar_partida", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("inicioPartidaTotales")},
        
        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("inicioPartidaTotales"));
    }

    public void continuar_partida()
    {
        AnalyticsService.Instance.CustomData("continuar_partida", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("continuarPartidaTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("continuarPartidaTotales"));

    }

    public void codex()
    {
        AnalyticsService.Instance.CustomData("codex", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("codexTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("codexTotales"));

    }

    public void ver_mapa()
    {
        AnalyticsService.Instance.CustomData("ver_mapa", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("mapaTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("mapaTotales"));
    }

    public void borrar_animal()
    {
        AnalyticsService.Instance.CustomData("borrar_animal", new Dictionary<string, object>(){
            {"numero_id", PlayerPrefs.GetInt("IndexDesocuparJaula")},

        }); //TERMINADO
        Debug.Log("numero_id" + PlayerPrefs.GetInt("IndexDesocuparJaula"));
    }

    public void stasis()
    {
        AnalyticsService.Instance.CustomData("stasis", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("stasisTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("stasisTotales"));
    }

    public void leer_tutorial()
    {
        AnalyticsService.Instance.CustomData("leer_tutorial", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("tutorialTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("tutorialTotales"));
    }

    public void fin_del_turno()
    {
        AnalyticsService.Instance.CustomData("fin_del_turno", new Dictionary<string, object>(){
            {"popularidad", PlayerPrefs.GetInt("Popularidad")},
            {"cupos", PlayerPrefs.GetInt("JaulasOcupadas")},
            {"dias", PlayerPrefs.GetInt("Dias")},
            {"dinero", PlayerPrefs.GetInt("Moneditas")},
            {"tiempo", PlayerPrefs.GetInt("TiempoJuego")},

        }); //TERMINADO

        Debug.Log("popularidad" + PlayerPrefs.GetInt("Popularidad"));
        Debug.Log("cupos" + PlayerPrefs.GetInt("JaulasOcupadas"));
        Debug.Log("dias" + PlayerPrefs.GetInt("Dias"));
        Debug.Log("dinero" + PlayerPrefs.GetInt("Moneditas"));
        Debug.Log("tiempo" + PlayerPrefs.GetInt("TiempoJuego"));
    }

    public void leer_evento()
    {
        AnalyticsService.Instance.CustomData("leer_evento", new Dictionary<string, object>(){
            {"numero_id", PlayerPrefs.GetInt("eventNumber")},
            {"opcionElegida", PlayerPrefs.GetInt("eventoElegido")},


        }); //TERMINADO
        Debug.Log("numero_id" + PlayerPrefs.GetInt("eventNumber"));
        Debug.Log("opcionElegida" + PlayerPrefs.GetInt("eventoElegido"));
    }

    public void mandar_a_stasis()
    {
        AnalyticsService.Instance.CustomData("mandar_a_stasis", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("enviarStasisTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("enviarStasisTotales"));
    }

    public void mandar_a_lazaro()
    {
        AnalyticsService.Instance.CustomData("mandar_a_lazaro", new Dictionary<string, object>(){
            {"vez", PlayerPrefs.GetInt("enviarLazaroTotales")},

        }); //TERMINADO
        Debug.Log("vez" + PlayerPrefs.GetInt("enviarLazaroTotales"));
    }

    public void calificacion()
    {
        AnalyticsService.Instance.CustomData("calificacion", new Dictionary<string, object>(){
            {"graficos", PlayerPrefs.GetInt("CalifGraficos")},
            {"jugabilidad", PlayerPrefs.GetInt("CalifJugabilidad")},
            {"redacci�n", PlayerPrefs.GetInt("CalifRedaccion")},
            {"contenido", PlayerPrefs.GetInt("CalifContenido")},

        }); //TERMINADO
        Debug.Log("graficos" + PlayerPrefs.GetInt("CalifGraficos"));
        Debug.Log("jugabilidad" + PlayerPrefs.GetInt("CalifJugabilidad"));
        Debug.Log("redacci�n" + PlayerPrefs.GetInt("CalifRedaccion"));
        Debug.Log("contenido" + PlayerPrefs.GetInt("CalifContenido"));
    }

     public void logro()
    {
        AnalyticsService.Instance.CustomData("logro", new Dictionary<string, object>(){
            {"logro0", PlayerPrefs.GetInt("Logro0")},
            {"logro1", PlayerPrefs.GetInt("Logro1")},
            {"logro2", PlayerPrefs.GetInt("Logro2")},
            {"logro3", PlayerPrefs.GetInt("Logro3")},
            {"logro4", PlayerPrefs.GetInt("Logro4")},
            {"logro5", PlayerPrefs.GetInt("Logro5")},
            {"logro6", PlayerPrefs.GetInt("Logro6")},
            {"logro7", PlayerPrefs.GetInt("Logro7")},
            {"logro8", PlayerPrefs.GetInt("Logro8")},
            {"logro9", PlayerPrefs.GetInt("Logro9")},
            {"logro10", PlayerPrefs.GetInt("Logro10")},
            {"logro11", PlayerPrefs.GetInt("Logro11")},
            {"logro12", PlayerPrefs.GetInt("Logro12")},
            {"logro13", PlayerPrefs.GetInt("Logro13")},
            {"logro14", PlayerPrefs.GetInt("Logro14")},
            {"logro15", PlayerPrefs.GetInt("Logro15")},
            {"logro16", PlayerPrefs.GetInt("Logro16")},
            {"logro17", PlayerPrefs.GetInt("Logro17")},
            {"logro18", PlayerPrefs.GetInt("Logro18")},
            {"logro19", PlayerPrefs.GetInt("Logro19")},
            {"logro20", PlayerPrefs.GetInt("Logro20")},
            {"logro21", PlayerPrefs.GetInt("Logro21")},
            {"logro22", PlayerPrefs.GetInt("Logro22")},
            {"logro23", PlayerPrefs.GetInt("Logro23")},
            {"logro24", PlayerPrefs.GetInt("Logro24")},
            {"logro25", PlayerPrefs.GetInt("Logro25")},
            {"logro26", PlayerPrefs.GetInt("Logro26")},
            {"logro27", PlayerPrefs.GetInt("Logro27")},
            {"logro28", PlayerPrefs.GetInt("Logro28")},
        }); //TERMINADO
    }
}


// Update is called once per frame

//public void perderEvent()
//{
//    Unity.Services.Analytics("CuantoDineroTeniasCuandoPerdiste", PlayerPrefs.GetInt("Moneditas"));
//}

