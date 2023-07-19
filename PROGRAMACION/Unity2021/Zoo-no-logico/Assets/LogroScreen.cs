using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;
using System;
using System.Linq;

[System.Serializable]
public class LogroR
{
    public string id;
    public string titulo;
    public string descripcion;
}

[System.Serializable]
public class LogroListR
{
    public List<LogroR> logros;
}

public class LogroScreen : MonoBehaviour
{
    public TextAsset LogrosJson;

    public GameObject Icono;
    public GameObject Titulo;
    public GameObject Descripcion;

    public LogroListR myLogroList = new LogroListR();

     public string jsonString;

    private void Awake()
    {
        LoadLogros();
    }

    // Start is called before the first frame update
    void Update()
    {
        GetAchievement();
    }

    void LoadLogros()
    {
        myLogroList = JsonUtility.FromJson<LogroListR>(LogrosJson.text);

        Debug.Log(myLogroList);
    }

    void GetAchievement()
    {
        Sprite logro_img = Resources.Load<Sprite>("Logros/" + gameObject.name);

        SpriteRenderer icono_img = Icono.GetComponent<SpriteRenderer>();

        icono_img.sprite = logro_img;

        // Texto de Logros
        foreach (var logro in myLogroList.logros)
        {
            if (logro.id == gameObject.name)
            {
                if (PlayerPrefs.GetInt("Logro" + logro.id) == 1)
                {
                    icono_img.color = Color.white;

                    Titulo.GetComponent<Text>().color = new Color(0.1647059f, 0.3098039f, 0.1411765f);
                    Titulo.GetComponent<Text>().text = logro.titulo;

                    Descripcion.GetComponent<Text>().color = new Color(0.1647059f, 0.3098039f, 0.1411765f);
                    Descripcion.GetComponent<Text>().text = logro.descripcion;
                }
                else
                {
                    icono_img.color = Color.black;

                    Titulo.GetComponent<Text>().color = Color.black;
                    Titulo.GetComponent<Text>().text = logro.titulo;

                    Descripcion.GetComponent<Text>().color = Color.black;
                    Descripcion.GetComponent<Text>().text = "No has desbloqueado este logro";
                }
            }
        }
    }
}
