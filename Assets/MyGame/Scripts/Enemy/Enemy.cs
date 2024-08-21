using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[AddComponentMenu("ThinhLe/Enemy")]
public class Enemy : MonoBehaviour,ICanTakeDamage
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isDead = false;
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
            isDead = true;
            DeadEnemy();
        }
    }
    private void DeadEnemy()
    {
        Destroy(gameObject);
    }

}
