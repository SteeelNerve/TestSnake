using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverWindow : MonoBehaviour
{
    private static GameOverWindow instance;

    private void Awake()
    {
        instance = this;
        Hide();
    }

    public void LoadGameAgain()
    {
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Show(bool isNewHighScore)
    {
        gameObject.SetActive(true);

        transform.Find("NewHighScoreText").gameObject.SetActive(isNewHighScore);

        transform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = Score.GetScore().ToString();
        transform.Find("highScoreText").GetComponent<TextMeshProUGUI>().text = "HIGHSCORE " + Score.GetHighscore();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic(bool isNewHighScore)
    {
        instance.Show(isNewHighScore);
    }
}
