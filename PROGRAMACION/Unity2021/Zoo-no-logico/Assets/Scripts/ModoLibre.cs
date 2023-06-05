using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModoLibre : MonoBehaviour
{

    public GameObject continuar;
    public GameObject modoLibre;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Ganaste") == 1)
        {
            continuar.SetActive(false);
            modoLibre.SetActive(true);
        }
        else
        {
            continuar.SetActive(true);
            modoLibre.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
