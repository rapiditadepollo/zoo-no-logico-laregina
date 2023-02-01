using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiendaSlot : MonoBehaviour
{

    public Sprite slotCarpincho;
    public Sprite slotZorro;
    public Sprite slotCocodrilo;
    public Sprite slotMurcielago;
    public Sprite slotAve;
    public Sprite slotSerpiente;
    public Sprite slotArana;
    public Sprite Carpincho;
    public Sprite Zorro;
    public Sprite Cocodrilo;
    public Sprite Murcielago;
    public Sprite Ave;
    public Sprite Serpiente;
    public Sprite Arana;

    public SpriteRenderer boton1;
    public SpriteRenderer boton2;
    public SpriteRenderer boton3;
    public SpriteRenderer boton4;
    public SpriteRenderer boton5;
    public SpriteRenderer boton6;
    public SpriteRenderer boton7;

    public SpriteRenderer slot1;
    public SpriteRenderer slot2;
    public SpriteRenderer slot3;
    public SpriteRenderer slot4;
    public SpriteRenderer slot5;
    public SpriteRenderer slot6;
    public SpriteRenderer slot7;

    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetString("animal1Tienda"))
        {
            case "Carpincho":
                slot1.sprite = slotCarpincho;
                boton1.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot1.sprite = slotCocodrilo;
                boton1.sprite = Cocodrilo;
                break;
            case "Ave":
                slot1.sprite = slotAve;
                boton1.sprite = Ave;
                break;
            case "Serpiente":
                slot1.sprite = slotSerpiente;
                boton1.sprite = Serpiente;
                break;
            case "Murcielago":
                slot1.sprite = slotMurcielago;
                boton1.sprite = Murcielago;
                break;
            case "Zorro":
                slot1.sprite = slotZorro;
                boton1.sprite = Zorro;
                break;
            case "Arana":
                slot1.sprite = slotArana;
                boton1.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal2Tienda"))
        {
            case "Carpincho":
                slot2.sprite = slotCarpincho;
                boton2.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot2.sprite = slotCocodrilo;
                boton2.sprite = Cocodrilo;
                break;
            case "Ave":
                slot2.sprite = slotAve;
                boton2.sprite = Ave;
                break;
            case "Serpiente":
                slot2.sprite = slotSerpiente;
                boton2.sprite = Serpiente;
                break;
            case "Murcielago":
                slot2.sprite = slotMurcielago;
                boton2.sprite = Murcielago;
                break;
            case "Zorro":
                slot2.sprite = slotZorro;
                boton2.sprite = Zorro;
                break;
            case "Arana":
                slot2.sprite = slotArana;
                boton1.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal3Tienda"))
        {
            case "Carpincho":
                slot3.sprite = slotCarpincho;
                boton3.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot3.sprite = slotCocodrilo;
                boton3.sprite = Cocodrilo;
                break;
            case "Ave":
                slot3.sprite = slotAve;
                boton3.sprite = Ave;
                break;
            case "Serpiente":
                slot3.sprite = slotSerpiente;
                boton3.sprite = Serpiente;
                break;
            case "Murcielago":
                slot3.sprite = slotMurcielago;
                boton3.sprite = Murcielago;
                break;
            case "Zorro":
                slot3.sprite = slotZorro;
                boton3.sprite = Zorro;
                break;
            case "Arana":
                slot3.sprite = slotArana;
                boton3.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal4Tienda"))
        {
            case "Carpincho":
                slot4.sprite = slotCarpincho;
                boton4.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot4.sprite = slotCocodrilo;
                boton4.sprite = Cocodrilo;
                break;
            case "Ave":
                slot4.sprite = slotAve;
                boton4.sprite = Ave;
                break;
            case "Serpiente":
                slot4.sprite = slotSerpiente;
                boton4.sprite = Serpiente;
                break;
            case "Murcielago":
                slot4.sprite = slotMurcielago;
                boton4.sprite = Murcielago;
                break;
            case "Zorro":
                slot4.sprite = slotZorro;
                boton4.sprite = Zorro;
                break;
            case "Arana":
                slot4.sprite = slotArana;
                boton4.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal5Tienda"))
        {
            case "Carpincho":
                slot5.sprite = slotCarpincho;
                boton5.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot5.sprite = slotCocodrilo;
                boton5.sprite = Cocodrilo;
                break;
            case "Ave":
                slot5.sprite = slotAve;
                boton5.sprite = Ave;
                break;
            case "Serpiente":
                slot5.sprite = slotSerpiente;
                boton5.sprite = Serpiente;
                break;
            case "Murcielago":
                slot5.sprite = slotMurcielago;
                boton5.sprite = Murcielago;
                break;
            case "Zorro":
                slot5.sprite = slotZorro;
                boton5.sprite = Zorro;
                break;
            case "Arana":
                slot5.sprite = slotArana;
                boton5.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal6Tienda"))
        {
            case "Carpincho":
                slot6.sprite = slotCarpincho;
                boton6.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot6.sprite = slotCocodrilo;
                boton6.sprite = Cocodrilo;
                break;
            case "Ave":
                slot6.sprite = slotAve;
                boton6.sprite = Ave;
                break;
            case "Serpiente":
                slot6.sprite = slotSerpiente;
                boton6.sprite = Serpiente;
                break;
            case "Murcielago":
                slot6.sprite = slotMurcielago;
                boton6.sprite = Murcielago;
                break;
            case "Zorro":
                slot6.sprite = slotZorro;
                boton6.sprite = Zorro;
                break;
            case "Arana":
                slot6.sprite = slotArana;
                boton6.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

        switch (PlayerPrefs.GetString("animal7Tienda"))
        {
            case "Carpincho":
                slot7.sprite = slotCarpincho;
                boton7.sprite = Carpincho;
                break;
            case "Cocodrilo":
                slot7.sprite = slotCocodrilo;
                boton7.sprite = Cocodrilo;
                break;
            case "Ave":
                slot7.sprite = slotAve;
                boton7.sprite = Ave;
                break;
            case "Serpiente":
                slot7.sprite = slotSerpiente;
                boton7.sprite = Serpiente;
                break;
            case "Murcielago":
                slot7.sprite = slotMurcielago;
                boton7.sprite = Murcielago;
                break;
            case "Zorro":
                slot7.sprite = slotZorro;
                boton7.sprite = Zorro;
                break;
            case "Arana":
                slot7.sprite = slotArana;
                boton7.sprite = Arana;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
