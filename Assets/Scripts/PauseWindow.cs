using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWindow : MonoBehaviour
{
    private static PauseWindow instance;
    private void Awake()
    {
        instance = this;

        transform.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        Hide();
    }

    public void ToMainWindow()
    {
        Loader.Load(Loader.Scene.MainMenu);
    }

    public void UnpauseGame()
    {
        GameHandler.ResumeGame();
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        instance.Show();
    }

    public static void HideStatic()
    {
        instance.Hide();
    }
}
