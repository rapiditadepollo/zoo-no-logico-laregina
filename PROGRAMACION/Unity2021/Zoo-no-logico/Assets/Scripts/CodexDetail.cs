using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class CodexDetail : MonoBehaviour
{
    public TextAsset Cruzas;
    public Text nombre;
    public Text descripcion;
    public Text dato1;
    public Text dato2;
    public Text dato3;
    public Image foto;
    public GameObject[] CruzasArray;

    public SpriteRenderer estrella1;
    public SpriteRenderer estrella2;
    public SpriteRenderer estrella3;

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
        GetCruzas();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myCruzaList = JsonUtility.FromJson<CruzaList>(Cruzas.text);
        int index = PlayerPrefs.GetInt("codexCruzaNro");
        print(index);
        print(myCruzaList.cruza );
        descripcion.text = myCruzaList.cruza[index].descripcion;
        nombre.text = myCruzaList.cruza[index].nombre;
        dato1.text = myCruzaList.cruza[index].dato1;
        dato2.text = myCruzaList.cruza[index].dato2;
        dato3.text = myCruzaList.cruza[index].dato3;

        Sprite cruza_test_img = Resources.Load<Sprite>(index.ToString());
        print(CruzasArray.Length);
        Image Cruza_image = CruzasArray[index].GetComponent<Image>();

        foto.sprite = cruza_test_img;

        if (index < 35 && myCruzaList.cruza[index].peligrosidad == 1)
        {
            estrella1.color = Color.white;
            estrella2.color = Color.grey;
            estrella3.color = Color.grey;
        }
        if (index < 35 && myCruzaList.cruza[index].peligrosidad == 2)
        {
            estrella1.color = Color.white;
            estrella2.color = Color.white;
            estrella3.color = Color.grey;
        }
        if (index < 35 && myCruzaList.cruza[index].peligrosidad == 3)
        {
            estrella1.color = Color.white;
            estrella2.color = Color.white;
            estrella3.color = Color.white;
        }

    }

    GameObject[] GetCruzas()
    {
        CruzasArray = GameObject.FindGameObjectsWithTag("CruzaSlot");
        print(CruzasArray);
        Array.Sort(CruzasArray, CompareJaulas);
        return CruzasArray;
    }

    private int CompareJaulas(GameObject x, GameObject y)
    {
        return Int16.Parse(x.name).CompareTo(Int16.Parse(y.name));
    }
}
