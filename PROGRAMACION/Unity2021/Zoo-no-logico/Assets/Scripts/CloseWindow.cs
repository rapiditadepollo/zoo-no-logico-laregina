using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{

    public GameObject window;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openWindow()
    {
        window.SetActive(true);
    }

    public void closeWindow()
    {
        window.SetActive(false);

    }
}
