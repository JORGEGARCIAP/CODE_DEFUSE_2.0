using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScore
{
    private CompararHighScore _compararHighScore = new CompararHighScore();

    public float _HighScore(float TiempoRestante, float MiHighScoreDeEsteNivel, string Nivel)
    {
        
        float TiempoFinal = 60 - TiempoRestante;
        _compararHighScore.SetHighScore(TiempoFinal, MiHighScoreDeEsteNivel, Nivel);

        return TiempoFinal;
    }
    
}
