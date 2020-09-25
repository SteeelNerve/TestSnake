using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : MonoBehaviour
{
    private enum Sub
    {
        Main, 
        HowToPlay,
    }

    private void Awake()
    {
        transform.Find("howToPlaySub").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.Find("mainSub").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

        ShowSub(Sub.Main);
    }

    public void LoadGame()
    {
        Loader.Load(Loader.Scene.GameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMain()
    {
        ShowSub(Sub.Main);
    }

    public void HowToPlay()
    {
        ShowSub(Sub.HowToPlay);
    }

    private void ShowSub(Sub sub)
    {
        transform.Find("mainSub").gameObject.SetActive(false);
        transform.Find("howToPlaySub").gameObject.SetActive(false);

        switch (sub)
        {
            case Sub.Main:
            {
                transform.Find("mainSub").gameObject.SetActive(true);
                break;
            }
            case Sub.HowToPlay:
            {
                transform.Find("howToPlaySub").gameObject.SetActive(true);
                break;
            }
        }
    }
}
