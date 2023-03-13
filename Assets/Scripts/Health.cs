using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int almostDead = 30;
    public int minHealth = 0;
    public int currentHealth;
    public HealthBar healthBar;

    public Animator lowLife;


    void Start() 
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            TakeDamage(5);
            lowLife.SetTrigger("hurt");

        }


    }

    private void Update()
    {
        if (currentHealth <= minHealth)
        {
            lowLife.SetTrigger("Death");
            gameObject.SetActive(false);

        }
    }
}
