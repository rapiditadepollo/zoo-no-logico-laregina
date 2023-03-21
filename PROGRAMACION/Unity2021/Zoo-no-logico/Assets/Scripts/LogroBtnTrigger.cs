using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;
using System;
using System.Linq;

public class LogroBtnTrigger : MonoBehaviour
{
    public TextAsset LogrosJson;

    public LogroList myLogroList = new LogroList();

    public GameObject LogrosObject;

    // Start is called before the first frame update
    void Start()
    {
        LoadLogros();

        LogrosObject = GameObject.FindGameObjectWithTag("Logros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLogros()
    {
        string json = File.ReadAllText(Application.dataPath + "/Json/Logros.json");
        JsonUtility.FromJsonOverwrite(json, myLogroList);
    }

    public void TriggerAchievement(string id)
    {
        LogrosObject.SendMessage("UnlockAchievement", id);
    }
}