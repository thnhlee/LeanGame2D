using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
[AddComponentMenu("ThinhLe/DataManger")]

public class DataManger
{
    const int defaultValue = 0;
    public static int DataCoin
    {
        get => PlayerPrefs.GetInt(DataKey.KeyCoinId, defaultValue);
        set => PlayerPrefs.SetInt(DataKey.KeyCoinId, value);
    }
}
