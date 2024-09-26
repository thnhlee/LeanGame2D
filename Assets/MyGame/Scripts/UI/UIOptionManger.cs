using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AddComponentMenu("ThinhLe/UIOptionManager")]
public class UIOptionManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    private void Start()
    {
        musicSlider.value = DataManger.DataMusic;
        sfxSlider.value = DataManger.DataSfx;
    }
    // Update is called once per frame
    public void UpdateMusic(float volume)
    {
        AudioManager.Instance.SetMusicVolume(volume);
        DataManger.DataMusic = volume;
    }
    public void UpdateSfx(float volune)
    {
        AudioManager.Instance.SetSfxVolume(volune);
        DataManger.DataSfx = volune;
    }
}