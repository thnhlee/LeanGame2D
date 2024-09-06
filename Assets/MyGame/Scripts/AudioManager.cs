using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/AudioManager")]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance
    {
        get => instance;
    }
    private static AudioManager instance;
    // Start is called before the first frame update
    [Header("Audio Source")]
    public AudioSource musicSource;
    public AudioSource sfxUISource;
    public AudioSource sfxEnemySource;
    [Header("Audio clip")]
    public AudioClip backgroundMusic;
    public AudioClip audioClick;
    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        PlayMusic(backgroundMusic);
    }
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }
    public void PlaySfxMusicUI(AudioClip clip)
    {
        sfxUISource.PlayOneShot(clip);
    }
    public void PlayOnClick()
    {
        PlaySfxMusicUI(audioClick);
    }
    public void PlayEnemySfxMusic(AudioClip clip)
    {
        sfxEnemySource.PlayOneShot(clip);
    }
}