using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("ThinhLe/GameSceneManager")]
public class GameSceneManager : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject optionUI;
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Main");
        AudioManager.Instance.PlayOnClick();
    }

    public void OnClickOption()
    {
        mainUI.SetActive(false);
        optionUI.SetActive(true);
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
}
