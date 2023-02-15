using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static ScoringSystem instance;




    public int PlayerScore;
    public int AIScore;


    public Text PlayerScoreText;
    public Text AIScoreText;
    public Text WinnerText;

    

    private void OnEnable()
    {
        instance= this;
    }



    private void Update()
    {
        if (PlayerScore >= 3)
        {
            Time.timeScale = 0f;
            WinnerText.text = "Player Won";
            SceneManager.LoadSceneAsync("GamesManager", LoadSceneMode.Single);
        }
        if (AIScore >= 3)
        {
            Time.timeScale = 0f;
            WinnerText.text = "AI Won";
            SceneManager.LoadSceneAsync("GamesManager",LoadSceneMode.Single);
        }
    }

}
