using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/CoinManager")]

public class CoinManager : MonoBehaviour
{
    public int coinNumber = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                GameManager.Instance.UpdateCoin(coinNumber);
                Destroy(gameObject);
            }
        }
    }
}
