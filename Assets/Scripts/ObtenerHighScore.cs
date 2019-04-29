using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerHighScore : MonoBehaviour
{
    private string NivelEasy = "ScoreEasy";
    private string NivelNormal = "ScoreNormal";
    private string NivelHard = "ScoreHard";
    private string NivelExpert = "ScoreExpert";
    float MiHighScoreParaEsteNivel;

    public float ObtenerHighScoreDeEsteNivel(int NivelEnElQueEstas)
    {
        switch (NivelEnElQueEstas)
        {
            case 8:
                if (PlayerPrefs.HasKey(NivelEasy) == false)
                {
                    PlayerPrefs.SetFloat(NivelEasy, 60);
                }
                MiHighScoreParaEsteNivel = PlayerPrefs.GetFloat(NivelEasy);
                break;

            case 9:
                if (PlayerPrefs.HasKey(NivelNormal) == false)
                {
                    PlayerPrefs.SetFloat(NivelNormal, 60);
                }
                MiHighScoreParaEsteNivel = PlayerPrefs.GetFloat(NivelNormal);
                break;

            case 10:
                if (PlayerPrefs.HasKey(NivelHard) == false)
                {
                    PlayerPrefs.SetFloat(NivelHard, 60);
                }
                MiHighScoreParaEsteNivel = PlayerPrefs.GetFloat(NivelHard);
                break;

            case 11:
                if (PlayerPrefs.HasKey(NivelExpert) == false)
                {
                    PlayerPrefs.SetFloat(NivelExpert, 60);
                }
                MiHighScoreParaEsteNivel = PlayerPrefs.GetFloat(NivelExpert);
                break;
        }
        return MiHighScoreParaEsteNivel;
    }
}
