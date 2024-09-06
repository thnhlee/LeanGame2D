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
    public static UIManager Instance
    {
        get => instance;
    }
    private static UIManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
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
}
