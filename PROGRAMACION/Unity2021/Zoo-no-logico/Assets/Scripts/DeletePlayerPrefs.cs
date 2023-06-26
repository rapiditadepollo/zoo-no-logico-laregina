using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeletePlayerPrefs : MonoBehaviour {

    public Button continuar;
    private string[] listaAnimales = new string[] { "Carpincho", "Cocodrilo", "Arana", "Zorro", "Murcielago", "Ave", "Serpiente" };


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("Dias") == 0){
            continuar.interactable = false;
        }
        else{
            continuar.interactable = true;
        }
	}

    public void Delete() {
        int inicioPartidaTotales = PlayerPrefs.GetInt("inicioPartidaTotales");
        PlayerPrefs.DeleteAll();



        //PlayerPrefs.SetInt("Jaula1", 89);
        //PlayerPrefs.SetInt("Jaula2", 89);
        //PlayerPrefs.SetInt("Jaula3", 89);
        //PlayerPrefs.SetInt("Jaula4", 89);
        //PlayerPrefs.SetInt("Jaula5", 89);

        PlayerPrefs.SetInt("Moneditas", 15000);

        PlayerPrefs.SetInt("Popularidad", 20);

        PlayerPrefs.SetInt("CantidadCarpincho", 0);
        PlayerPrefs.SetInt("CantidadArana", 0);
        PlayerPrefs.SetInt("CantidadCocodrilo", 1);
        PlayerPrefs.SetInt("CantidadZorro", 1);
        PlayerPrefs.SetInt("CantidadMurcielago", 1);
        PlayerPrefs.SetInt("CantidadSerpiente", 0);
        PlayerPrefs.SetInt("CantidadAve", 0);
        PlayerPrefs.SetString("PrimeraCombinacion", "true");
        PlayerPrefs.SetInt("inicioPartidaTotales", inicioPartidaTotales + 1);

        PlayerPrefs.SetString("animal1Tienda", listaAnimales[0]);
        PlayerPrefs.SetString("animal2Tienda", listaAnimales[1]);
        PlayerPrefs.SetString("animal3Tienda", listaAnimales[2]);
        PlayerPrefs.SetString("animal4Tienda", listaAnimales[3]);
        PlayerPrefs.SetString("animal5Tienda", listaAnimales[4]);
        PlayerPrefs.SetString("animal6Tienda", listaAnimales[5]);
        PlayerPrefs.SetString("animal7Tienda", listaAnimales[6]);

        for (int i = 0; i < 20; i++)
        {
            PlayerPrefs.SetInt("Jaula" + i, 89);
        }

        PlayerPrefs.SetInt("ResetListCartas", 0);
        PlayerPrefs.SetInt("EventoCartas", 0);
        PlayerPrefs.SetInt("DesactivarNoti", 0);

        for (int i = 0; i < 28; i++)
        {
            PlayerPrefs.SetInt("Logro" + i, 0);
            PlayerPrefs.SetInt("Logro" + i + "Unlocked", 0);
        }
    }
}
