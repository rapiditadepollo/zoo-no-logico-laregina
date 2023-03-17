using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;

[System.Serializable]
public class Logro
{
    public string id;
    public string titulo;
    public string descripcion;
    public bool runCheck;
    public Condition condicion;
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
public class Logros : MonoBehaviour { 

    public TextAsset LogrosJson;

    public GameObject Popup;

    public LogroList myLogroList = new LogroList();

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        PlayerPrefs.SetInt("Logro0", 0);
    }

    void Start()
    {
        LoadLogros();
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
        string json = File.ReadAllText(Application.dataPath + "/Json/Logros.json");
        JsonUtility.FromJsonOverwrite(json, myLogroList);
    }

    void CheckLogros()
    {

        foreach (Logro logro in myLogroList.logros)
        {
            Debug.Log(PlayerPrefs.GetInt("Logro" + logro.id));

                if (PlayerPrefs.GetInt("Logro" + logro.id) == 0)
                {

                if (logro.runCheck == true)
                {
                    Debug.Log("HAY CONDICION");

                    if (CheckCondition(logro.condicion))
                    {
                        UnlockAchievement(logro.id);
                    }
                }
                else
                {
                    Debug.Log("NO HAY CONDICION");
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

        Debug.Log(condicion.tipo);
        Debug.Log(condicion.variable);
        Debug.Log(condicion.operador);
        Debug.Log(condicion.valor);
        Debug.Log(PlayerPrefs.GetInt(condicion.variable));

        if (condicion.tipo == "int")
        {
            switch (condicion.operador)
            {
                case ">":
                    return (PlayerPrefs.GetInt(condicion.variable) > condicion.valor);
                default:
                    return false;
            }
        }
        else
        {
            return false;
        }
    }

    void UnlockAchievement(string id)
    {

        PlayerPrefs.SetInt("Logro" + id, 1);
        Debug.Log("Logro " + id + " Desbloqueado");
        GetAchievement(int.Parse(id));
        StartCoroutine(ShowPopup());
    }

    private IEnumerator ShowPopup()
    {
        Popup.SetActive(true);
        yield return new WaitForSeconds(3);
        Popup.SetActive(false);
    }

    void GetAchievement(int id)
    {
        Sprite logro_img = Resources.Load<Sprite>("Logros/" + id);

        Debug.Log(logro_img);

        SpriteRenderer popup_img = Popup.GetComponent<SpriteRenderer>();

        popup_img.sprite = logro_img;
    }
}
