using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ThinhLe/Player")]
public class Player : MonoBehaviour,ICanTakeDamage
{
    public int maxHealth = 100;
    public int currentHealth;
    [HideInInspector] public bool isDead = false;
    private Animator anim;
    private int IsDeadId;
    public float timerDelay = 1.5f;
    private PlayerController playerController;
    private PlayerAttack playerAttack;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealth();
        anim = GetComponentInChildren<Animator>();
        IsDeadId = Animator.StringToHash("IsDead");
        playerController = GetComponent<PlayerController>();
        playerAttack = GetComponent<PlayerAttack>();
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

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            DeadPlayer();
        }
    }
    void DeadPlayer()
    {
        isDead = true;  
        Debug.Log("Player Dead");
        anim.SetTrigger(IsDeadId);
        // Sau khi chet
        playerAttack.enabled = false;
        playerController.enabled = false;
        //Delay bảng gameover sau 1,5s
        //// Cach 1:
        //StartCoroutine(UpdateUI());
        // Cach 2:
        Invoke("UpdateUI", timerDelay);
    }
    void UpdateHealth()
    {
        //Cach 1:
        //UIManager.Instance.UpdateHealth(currentHealth);
        //Cach 2(toi uu):
        GameEvent.eventHealth?.Invoke(currentHealth);

    }

    //Delay bảng gameover sau 1,5s
    //// Cach 1:
    //IEnumerator UpdateUI()
    //{
    //    yield return new WaitForSeconds(timerDelay);
    //    UIManager.Instance.UpdateUI();
    //}
    // Cach 2:
    void UpdateUI()
    {
        //Cach 1:
        //UIManager.Instance.UpdateUI();
        //Cach 2(toi uu):
        GameEvent.eventUpdateUI?.Invoke();
    }
}
