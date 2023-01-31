using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class CageDetailConstructor : MonoBehaviour
{
    public TextAsset Cruzas;
    public Text plata;
    public Text popularidad;
    public Image animal;
    public GameObject[] CruzasArray;
    public GameObject[] JaulasArray;

    [System.Serializable]
    public class Cruza
    {
        public string id;
        public string nombre;
        public string descripcion;
        public string dato1;
        public string dato2;
        public string dato3;
        public int porcentaje;
        public int popularidad;
        public int peligrosidad;
        public int dinero;
    }

    [System.Serializable]
    public class CruzaList
    {
        public Cruza[] cruza;
    }

    public CruzaList myCruzaList = new CruzaList();

    void Awake()
    {
        //PlayerPrefs.SetInt("totalCodex", 0);
        GetJaulas();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        myCruzaList = JsonUtility.FromJson<CruzaList>(Cruzas.text);
        int index = PlayerPrefs.GetInt("IndexDesocuparJaula");
        print(PlayerPrefs.GetInt("IndexDesocuparJaula"));

        Sprite cruza_test_img = Resources.Load<Sprite>(index.ToString());
        print(JaulasArray.Length);
        //Image Cruza_image = CruzasArray[index].GetComponent<Image>();

        animal.sprite = JaulasArray[index].GetComponent<Image>().sprite;
        int cageDivisor;
        if (PlayerPrefs.GetInt("cageDivisor") > 0)
        {
            cageDivisor = PlayerPrefs.GetInt("cageDivisor");
        }
        else
        {
            cageDivisor = 2;
        }
        print(PlayerPrefs.GetInt("cage" + index.ToString() + "Money"));
        int plataInt = PlayerPrefs.GetInt("cage" + index.ToString() + "Money") / cageDivisor;
        plata.text = plataInt.ToString();
    }

    GameObject[] GetJaulas()
    {
        JaulasArray = GameObject.FindGameObjectsWithTag("Jaula");
        Array.Sort(JaulasArray, CompareJaulas);
        return JaulasArray;
    }

    private int CompareJaulas(GameObject x, GameObject y)
    {
        return Int16.Parse(x.name).CompareTo(Int16.Parse(y.name));
    }
}
