using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerNivel
{
    public string NombreDeNivel;

    public string RegresarNombreDelNivel(int EscnaActual)
    {
        switch (EscnaActual)
        {
            case 8:
                NombreDeNivel = "ScoreEasy";
                return NombreDeNivel;
            case 9:
                NombreDeNivel = "ScoreNormal";
                return NombreDeNivel;
            case 10:
                NombreDeNivel = "ScoreHard";
                return NombreDeNivel;
            case 11:
                NombreDeNivel = "ScoreExpert";
                return NombreDeNivel;
        }

        return null;
    }

    
}
