using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarImagenHelp : MonoBehaviour
{
    public int Contador = 0;
    public int ContadorMin = 0;
    public int ContadorMax = 8;
    public GameObject BotonDrecho;
    public GameObject BotonLeft;
    public Image MiImagen;

    public Sprite Ayuda1;
    public Sprite Ayuda2;
    public Sprite Ayuda3;
    public Sprite Ayuda4;
    public Sprite Ayuda5;
    public Sprite Ayuda6;
    public Sprite Ayuda7;
    public Sprite Ayuda8;
    public Sprite Ayuda9;
    public Sprite Ayuda10;
    public Sprite Ayuda11;
    public Sprite Ayuda12;
    //public Sprite Ayuda13;
    //public Sprite Ayuda14;
    //public Sprite Ayuda15;

    void Start()
    {
        Contador = 0;
    }

    void Update()
    {

        switch (Contador)
        {
            case 0:
                MiImagen.sprite = Ayuda1;
                break;
            case 1:
                MiImagen.sprite = Ayuda2;
                break;
            case 2:
                MiImagen.sprite = Ayuda3;
                break;
            case 3:
                MiImagen.sprite = Ayuda4;
                break;
            case 4:
                MiImagen.sprite = Ayuda5;
                break;
            case 5:
                MiImagen.sprite = Ayuda6;
                break;
            case 6:
                MiImagen.sprite = Ayuda7;
                break;
            case 7:
                MiImagen.sprite = Ayuda8;
                break;
            case 8:
                MiImagen.sprite = Ayuda9;
                break;
            case 9:
                MiImagen.sprite = Ayuda10;
                break;
            case 10:
                MiImagen.sprite = Ayuda11;
                break;
            case 11:
                MiImagen.sprite = Ayuda12;
                break;
            /*case 12:
                MiImagen.sprite = Ayuda13;
                break;
            case 13:
                MiImagen.sprite = Ayuda14;
                break;
            case 14:
                MiImagen.sprite = Ayuda15;
                break;*/
        }

        if (Contador == ContadorMax)
        {
            BotonDrecho.SetActive(false);
        }

        else if (Contador == ContadorMin)
        {
            BotonLeft.SetActive(false);
        }
        else
        {
            BotonLeft.SetActive(true);
            BotonDrecho.SetActive(true);
        }
    }

    public void SumarContador ()
    {
        Contador += 1;
        if (Contador > ContadorMax)
        {
            Contador = ContadorMax;
        }
    }

    public void RestarContador()
    {
        Contador -= 1;
        if (Contador < ContadorMin)
        {
            Contador = ContadorMin;
        }
    }
}
