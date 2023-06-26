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
public class Logro
{
    public string id;
    public string titulo;
    public string descripcion;
    public bool runCheck;
    public Condition[] condicion;
}

[System.Serializable]
public class Condition
{
    public string variable;
    public string tipo;
    public string operador;
    public int valor;
}

[System.Serializable]
public class LogroList
{
    public List<Logro> logros;
}

public class Logros : MonoBehaviour
{

    public TextAsset LogrosJson;

    public GameObject Icono;
    public GameObject Titulo;
    public GameObject Fondo;

    public LogroList myLogroList = new LogroList();

    public List<string> achievementQueue;

    [SerializeField] private GameObject ANALYTICS;

    public string jsonString;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        ANALYTICS = GameObject.FindGameObjectWithTag("ANALYTICS");

        LoadLogros();

        // foreach (Logro logro in myLogroList.logros)
        // {
        //     PlayerPrefs.SetInt("Logro" + logro.id, 0);
        // }

        InvokeRepeating("RunQueue", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        int sceneID = SceneManager.GetActiveScene().buildIndex;
        if (sceneID > 1)
        {
            CheckLogros();
        }

        //if (PlayerPrefs.GetInt("Popularidad") > 50 && PlayerPrefs.GetInt("Logro0") == 0) {
        //    PlayerPrefs.SetInt("Logro0", 1);
        //    Debug.Log(myLogroList.logro[0].titulo);
        //    GetAchievement(int.Parse(myLogroList.logro[0].id));
        //    StartCoroutine(ShowPopup());
        //}

    }
    void LoadLogros()
    {
        myLogroList = JsonUtility.FromJson<LogroList>(LogrosJson.text);
        
        Debug.Log(myLogroList);
    }

    void CheckLogros()
    {

        foreach (Logro logro in myLogroList.logros)
        {
            if (PlayerPrefs.GetInt("Logro" + logro.id) == 0)
            {
                if (logro.runCheck == true)
                {
                        bool achievementGet = true;
                        foreach (Condition condition in logro.condicion)
                        {
                            if (!CheckCondition(condition))
                            {
                                achievementGet = false;
                            }
                        }

                        if (achievementGet && PlayerPrefs.GetInt("Logro" + logro.id + "Unlocked") != 1)
                        {
                            // UnlockAchievement(logro.id);
                            achievementQueue.Add(logro.id);

                            PlayerPrefs.SetInt("Logro" + logro.id, 1);
                            PlayerPrefs.SetInt("Logro" + logro.id + "Unlocked", 1);
                            ANALYTICS.SendMessage("logro");
                        }
                }
                else
                {
                }

            }

        }
    }

    bool CheckCondition(Condition condicion)
    {
        //switch (condicion.operador)
        //{
        //    case ">":
        //        return if (condicion.tipo == "int")
        //        {
        //            return (PlayerPrefs.GetInt(condicion.variable) > condicion.valor);
        //        }
        //        break;
        //    default:
        //        return false;
        //}

        //Debug.Log(condicion.tipo);
        //Debug.Log(condicion.variable);
        //Debug.Log(condicion.operador);
        //Debug.Log(condicion.valor);
        //Debug.Log(PlayerPrefs.GetInt(condicion.variable));

        if (condicion.tipo == "int")
        {
            switch (condicion.operador)
            {
                case ">":
                    return (PlayerPrefs.GetInt(condicion.variable) > condicion.valor);
                case "<":
                    return (PlayerPrefs.GetInt(condicion.variable) < condicion.valor);
                case "==":
                    return (PlayerPrefs.GetInt(condicion.variable) == condicion.valor);
                case ">=":
                    return (PlayerPrefs.GetInt(condicion.variable) >= condicion.valor);
                case "<=":
                    return (PlayerPrefs.GetInt(condicion.variable) <= condicion.valor);
                default:
                    return false;
            }
        }
        else
        {
            return false;
        }
    }

    private IEnumerator UnlockAchievement(string id)
    {
        // Debug.Log("Logro " + id + " Desbloqueado");
        GetAchievement(int.Parse(id));
        StartCoroutine(ShowPopup());
        yield return new WaitForSeconds(1);
    }

    private IEnumerator ShowPopup()
    {
        Icono.GetComponent<SpriteRenderer>().enabled = true;
        Fondo.GetComponent<SpriteRenderer>().enabled = true;
        Titulo.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(3);
        Icono.GetComponent<SpriteRenderer>().enabled = false;
        Fondo.GetComponent<SpriteRenderer>().enabled = false;
        Titulo.GetComponent<Text>().enabled = false;
    }

    void GetAchievement(int id)
    {
        Sprite logro_img = Resources.Load<Sprite>("Logros/" + id);

        //Debug.Log(logro_img);

        SpriteRenderer popup_img = Icono.GetComponent<SpriteRenderer>();

        popup_img.sprite = logro_img;

        // Texto de Logros

        foreach (var logro in myLogroList.logros)
        {
            if (logro.id == id.ToString())
            {
                // Debug.Log(logro.titulo);
                Titulo.GetComponent<Text>().text = logro.titulo;
            }
        }
    }

    void RunQueue()
    {
        if (achievementQueue.Count > 0 && achievementQueue[0] != null)
        {
            // foreach (var logro in achievementQueue)
            // {
            //     Debug.Log(logro);
            // }

            // Debug.Log("queue id = " + achievementQueue[0]);

            StartCoroutine(UnlockAchievement(achievementQueue[0]));

            achievementQueue.RemoveAt(0);
        }
    }
}
