using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueNivelMultiOnlineEscojiest : MonoBehaviour
{

    public Text CuadroDeTexto, dificultyonbutton;

    void Start()
    {
        CuadroDeTexto.text = "EASY";
    }

    public void NivelEscojido(string NombreDelBoton)
    {
        CuadroDeTexto.text = NombreDelBoton;
        dificultyonbutton.text = NombreDelBoton;
    }
}
