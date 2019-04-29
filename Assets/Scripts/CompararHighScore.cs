using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompararHighScore : MonoBehaviour {

    public float SetHighScore(float MiScore, float MiHighScoreDeEsteNivel, string Nivel)
    {
        if (MiScore < MiHighScoreDeEsteNivel)
        {
            PlayerPrefs.SetFloat(Nivel, MiScore);
        }

        return MiScore;
    }
}
