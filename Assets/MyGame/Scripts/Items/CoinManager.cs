using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/CoinManager")]

public class CoinManager : MonoBehaviour
{
    public AudioClip coinClip;
    public int coinNumber = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                GameEvent.eventCoin?.Invoke(coinNumber);

                //GameManager.Instance.UpdateCoin(coinNumber);
                AudioManager.Instance.PlayePlayerSfxMusic(coinClip);
                Destroy(gameObject);
            }
        }
    }
}
