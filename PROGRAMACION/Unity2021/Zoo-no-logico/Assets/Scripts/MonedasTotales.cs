using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasTotales : MonoBehaviour {



    public Text textoMonedas;   // Variable con objeto Texto
    public int Monedas;         // Monedas agarradas
    public GameObject testMonedas;
    public GameObject Button;
    public GameObject testMonedas2;

    public GameObject Cosoprueba;

    [SerializeField] private GameObject ANALYTICS;

    // Start is called before the first frame update
    void Start()
    {
        textoMonedas = GameObject.FindGameObjectWithTag("TextoMonedas").GetComponent<Text>(); // Busca el objeto por su tag y le da el componente Text
        
        ANALYTICS = GameObject.FindGameObjectWithTag("ANALYTICS");
    }


    // Update is called once per frame
    void Update()
    {
        Monedas = PlayerPrefs.GetInt("Moneditas");
        textoMonedas.text = PlayerPrefs.GetInt("Moneditas").ToString();     
    }

    public void ComprarJaulas(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {   
        if(Monedas > gastarPlata){
            testMonedas.SetActive(true);
        Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
        PlayerPrefs.SetInt("Moneditas", Monedas);
        }
        else{
            testMonedas2.SetActive(true);
        }

    }

        public void Comprar(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {   
        if(Monedas > gastarPlata){
        Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
        PlayerPrefs.SetInt("Moneditas", Monedas);

        }

    }

    public void Agregar(int agregarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        Monedas += agregarPlata; // Al int con mis monedas le voy a agregar el dato que recibe desde el botón
        PlayerPrefs.SetInt("Moneditas", Monedas);
    }

    public void AgregarButton()
    {
        Button.SetActive(true);
    }

    public void BorrarButton()
    {
        Destroy(Button);
    }
    //cuando el valor de monedas es menor a 100 se desactiva el boton de compra
    // public void InhabilitarButton(){
    //     if(Monedas>= 100){
    //         Button.SetActive(true);
    //     }
    //     else{
    //         Button.SetActive(false);
    //     }
    // }


    //COMPRAR ANIMALES :)

    public void Comprar1(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal1Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal1Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal1Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal1Tienda"));
            ANALYTICS.SendMessage("comprar");
            print("compre 1" + PlayerPrefs.GetString("animal1Tienda"));
        }
    }

    public void Comprar2(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            print(gastarPlata);
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal2Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal2Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal2Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal2Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

    public void Comprar3(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal3Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal3Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal3Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal3Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

    public void Comprar4(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal4Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal4Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal4Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal4Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

    public void Comprar5(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal5Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal5Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal5Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal5Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

    public void Comprar6(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal6Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal6Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal6Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal6Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

    public void Comprar7(int gastarPlata) // este método está recibiendo un int. Si nosotros llamamos este objeto con el botón, en el inspector deberia de aparecer un campo para rellenar
    {
        if (Monedas > gastarPlata)
        {
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            Monedas -= gastarPlata; // Al int con mis monedas le voy a restar el dato que recibe desde el botón
            PlayerPrefs.SetInt("Moneditas", Monedas);

            PlayerPrefs.SetInt("vezCompra", PlayerPrefs.GetInt("vezCompra") + 1);
            PlayerPrefs.SetString("animalCompra", PlayerPrefs.GetString("animal7Tienda"));

            PlayerPrefs.SetInt(PlayerPrefs.GetString("animal7Tienda") + "sTotales", PlayerPrefs.GetInt(PlayerPrefs.GetString("animal7Tienda") + "sTotales") + 1);
            Cosoprueba.SendMessage("SumarCantidad" + PlayerPrefs.GetString("animal7Tienda"));
            ANALYTICS.SendMessage("comprar");
        }
    }

}