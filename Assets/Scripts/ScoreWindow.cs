using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreWindow : MonoBehaviour {

    private static ScoreWindow instance;
    private TextMeshProUGUI scoreText;

    private void Awake() {
        instance = this;
        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();

        Score.OnHighscoreChanged += Score_OnHighScoreChanged;
        UpdateHighScore();
    }

    private void Score_OnHighScoreChanged(object sender, EventArgs e)
    {
        UpdateHighScore();
    }

    private void Update() {
        scoreText.text = Score.GetScore().ToString();
    }

    private void UpdateHighScore()
    {
        int highscore = Score.GetHighscore();
        transform.Find("HighScoreText").GetComponent<TextMeshProUGUI>().text = "HIGHSCORE\n" + highscore.ToString();
    }

    public static void HideStatic()
    {
        instance.gameObject.SetActive(false);
    }

    
}
