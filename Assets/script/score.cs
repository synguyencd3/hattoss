﻿using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static int Scr = 0;
    public TextMeshProUGUI Highscore;
     public TextMeshProUGUI scoreText;
    void Start()
    {
      //  PlayerPrefs.DeleteAll();
        scoreText = GetComponent<TextMeshProUGUI>();
        Highscore.text = PlayerPrefs.GetInt("number", 0).ToString();

    }
    void Update()
    {
        scoreText.text = Scr.ToString();
        if (Scr > PlayerPrefs.GetInt("number", 0))
        {
            PlayerPrefs.SetInt("number", Scr);
            PlayerPrefs.Save();
            Highscore.text = Scr.ToString();
        }
    }
}
