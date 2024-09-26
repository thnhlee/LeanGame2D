using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[AddComponentMenu("ThinhLe/UIManager")]

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider sliderHealth;
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textHealth;
    [SerializeField] GameObject mainUI;
    [SerializeField] GameObject gameOverUI;


    private void Start()
    {
        UpdateCoin(DataManger.DataCoin);
        Invoke("Delay", 0.5f);
    }

    //Delay để đảm bảo start bên game manager chạy trc và bị null
    void Delay()
    {
        GameEvent.eventHealth.AddListener(UpdateHealth);
        GameEvent.eventCoinsCompleted.AddListener(UpdateCoin);
        GameEvent.eventUpdateUI.AddListener(UpdateUI);

    }

    // Update is called once per frame
    public void UpdateCoin(int coin)
    {
        textCoin.text = "Coin: " + coin.ToString();
    }
    public void UpdateHealth(int health)
    {
        sliderHealth.value = health;
        textHealth.text = "Health: " + health.ToString();
    }
    public void UpdateUI()
    {
        mainUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
