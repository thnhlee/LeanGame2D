using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/Player")]
public class Player : MonoBehaviour,ICanTakeDamage
{
    public int maxHealth = 100;
    public int currentHealth;
    [HideInInspector] public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealth();
    }

 

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage, Vector2 force, GameObject instigator)
    {
        if (isDead) return;
        currentHealth -= damage;
        UpdateHealth();

        if (currentHealth < 0)
        {
            currentHealth = 0;
            DeadPlayer();
        }
    }
    void DeadPlayer()
    {
        isDead = true;  
        Debug.Log("Player Dead");
    }
    void UpdateHealth()
    {
        UIManager.Instance.UpdateHealth(currentHealth);

    }
}
