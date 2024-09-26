using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/Bullet")]

public class Bullet : MonoBehaviour
{
    [Header("Property")]
    public GameObject fxPrefabs;
    public int damagevalue = 10;
    [Header("Audio")]
    public AudioClip audioClip;
    [Header("Timer Destroy Bullet")]
    public float timerDestroy = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timerDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.Instance.PlayePlayerSfxMusic(audioClip);
        Instantiate(fxPrefabs, transform.position, Quaternion.identity);
        if (collision.CompareTag("Enemy"))
        {
            ICanTakeDamage takeDamage = collision.GetComponent<ICanTakeDamage>();

            if (takeDamage != null)
            {
                takeDamage.TakeDamage(damagevalue, Vector2.zero, gameObject);
            }


            Destroy(gameObject);
        }
    }
}
