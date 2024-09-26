using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[AddComponentMenu("ThinhLe/GameManager")]

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get => instance;
    }
    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
    }
    public int coin;

    // Start is called before the first frame update
    void Start()
    {
        this.coin = DataManger.DataCoin;
        //this.coin = PlayerPrefs.GetInt("Keycoin", 0);

        if (GameEvent.eventHealth == null) GameEvent.eventHealth = new UnityEvent<int>();        
        if (GameEvent.eventCoin == null) GameEvent.eventCoin = new UnityEvent<int>();
        if (GameEvent.eventUpdateUI == null) GameEvent.eventUpdateUI = new UnityEvent();        
        if (GameEvent.eventCoinsCompleted == null) GameEvent.eventCoinsCompleted = new UnityEvent<int>();
        GameEvent.eventCoin.AddListener(UpdateCoin);  
    }
    // Update is called once per frame
    public void UpdateCoin(int coin)
    {
        this.coin += coin;
        DataManger.DataCoin = this.coin;
        GameEvent.eventCoinsCompleted?.Invoke(this.coin);
        //PlayerPrefs.SetInt("Keycoin",this.coin);
    }
}
