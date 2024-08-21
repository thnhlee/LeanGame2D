using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/Player")]
public class Player : MonoBehaviour,ICanTakeDamage
{
    public int maxHealth = 100;
    private int currentHealth;
    [HideInInspector] public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage, Vector2 force, GameObject instigator)
    {
        if (isDead) return;
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            DeadPlayer();
        }
    }
    void DeadPlayer()
    {
        Debug.Log("Player Dead");
    }
   }
