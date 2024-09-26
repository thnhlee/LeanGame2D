using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[AddComponentMenu("ThinhLe/SpikeTrap")]

public class SpikeTrap : MonoBehaviour
{
    [Header("Damage Health")]
    public int maxHealth = 100;
    [Header("Audio")]
    public AudioClip audioClip;
    [Header("fx")]
    public GameObject fxPrefabs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(fxPrefabs, transform.position, Quaternion.identity);
            AudioManager.Instance.PlayePlayerSfxMusic(audioClip);
            ICanTakeDamage takeDamage = collision.GetComponent<ICanTakeDamage>();
            if (takeDamage != null)
            {
                takeDamage.TakeDamage(maxHealth, Vector2.zero, gameObject);
            }
        }
    }
}
