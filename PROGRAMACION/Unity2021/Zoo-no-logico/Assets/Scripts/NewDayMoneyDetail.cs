using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDayMoneyDetail : MonoBehaviour
{

    public GameObject detailContainer;

    public Text jaula1;
    public Text jaula2;
    public Text jaula3;
    public Text jaula4;
    public Text jaula5;
    public Text jaula6;
    public Text jaula7;
    public Text jaula8;
    public Text jaula9;
    public Text jaula10;
    public Text jaula11;
    public Text jaula12;
    public Text jaula13;
    public Text jaula14;
    public Text jaula15;
    public Text jaula16;
    public Text jaula17;
    public Text jaula18;
    public Text jaula19;
    public Text jaula20;

    public Text multiplicador;
    public Text impuesto;
    public Text popularidad;

    public Text monedasTotales;
    public Text popularidadTotal;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("cageDivisor", 2);
        print(PlayerPrefs.GetInt("cage1Money") / PlayerPrefs.GetInt("cageDivisor"));
        jaula1.text = (PlayerPrefs.GetInt("cage0Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula2.text = (PlayerPrefs.GetInt("cage1Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula3.text = (PlayerPrefs.GetInt("cage2Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula4.text = (PlayerPrefs.GetInt("cage3Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula5.text = (PlayerPrefs.GetInt("cage4Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula6.text = (PlayerPrefs.GetInt("cage5Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula7.text = (PlayerPrefs.GetInt("cage6Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula8.text = (PlayerPrefs.GetInt("cage7Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula9.text = (PlayerPrefs.GetInt("cage8Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula10.text = (PlayerPrefs.GetInt("cage9Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula11.text = (PlayerPrefs.GetInt("cage10Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula12.text = (PlayerPrefs.GetInt("cage11Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula13.text = (PlayerPrefs.GetInt("cage12Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula14.text = (PlayerPrefs.GetInt("cage13Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula15.text = (PlayerPrefs.GetInt("cage14Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula16.text = (PlayerPrefs.GetInt("cage15Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula17.text = (PlayerPrefs.GetInt("cage16Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula18.text = (PlayerPrefs.GetInt("cage17Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula19.text = (PlayerPrefs.GetInt("cage18Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();
        jaula20.text = (PlayerPrefs.GetInt("cage19Money") / PlayerPrefs.GetInt("cageDivisor")).ToString();



        multiplicador.text = "x" + PlayerPrefs.GetFloat("popularityMultipliyer").ToString();
        impuesto.text = PlayerPrefs.GetFloat("impuestoDiario").ToString();
        popularidad.text = PlayerPrefs.GetInt("impuestoDeuda").ToString();

        monedasTotales.text = PlayerPrefs.GetInt("newMoneyInt").ToString();
    }

    public void CerrarDetalle()
    {
        detailContainer.SetActive(false);
    }

}
