using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
[AddComponentMenu("ThinhLe/PauseGameManager")]

public class PauseGameManager : MonoBehaviour
{
    bool isPause;
    public GameObject panelPause;
    public void OnPauseClick()
    {
        AudioManager.Instance.PlayOnClick();
        isPause =! isPause;
        if(!isPause )
        {

        }
        else
        {
            panelPause.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void OnResumeClick()
    {
        AudioManager.Instance.PlayOnClick();
        Time.timeScale = 1.0f;
        panelPause.SetActive(false);
    }
}
