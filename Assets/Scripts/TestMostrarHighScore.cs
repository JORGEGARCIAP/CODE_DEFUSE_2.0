using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMostrarHighScore : MonoBehaviour {

    void Start ()
    {
        Debug.Log(PlayerPrefs.GetFloat("ScoreEasy"));

        Debug.Log(PlayerPrefs.GetFloat("ScoreNormal"));

        Debug.Log(PlayerPrefs.GetFloat("ScoreHard"));

        Debug.Log(PlayerPrefs.GetFloat("ScoreExpert"));

    }
	
}
