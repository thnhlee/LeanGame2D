using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        UIManager.Instance.UpdateCoin(this.coin);
    }
    // Update is called once per frame
    public void UpdateCoin(int coin)
    {
        this.coin += coin;
        UIManager.Instance.UpdateCoin(this.coin);
        DataManger.DataCoin = this.coin;
        //PlayerPrefs.SetInt("Keycoin",this.coin);
    }
}
