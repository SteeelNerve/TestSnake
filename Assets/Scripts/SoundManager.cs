using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager: MonoBehaviour
{
    public enum Sound
    {
        SnakeMove,
        SnakeDie,
        SnakeEat, 
        ButtonClick,
        ButtonOver,
    }

    public static void PlaySound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach(GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.soundAudioClipArray)
        {
            if(soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound " + sound + " not found");
        return null;
    }

    public static void ClickButtonSound()
    {
        SoundManager.PlaySound(Sound.ButtonClick);
    }

    public static void HoverButtonSound()
    {
        SoundManager.PlaySound(Sound.ButtonOver);
    }
}
