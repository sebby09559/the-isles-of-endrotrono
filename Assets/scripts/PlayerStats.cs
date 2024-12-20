using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public float hunger = 100f;
    public float hungerDecreaseRate = 0.1f;
    public float healthRegenRate = 0.05f;
    public Transform respawnPoint;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        DecreaseHunger();
        RegenerateHealth();
        CheckDeath();
    }

    void DecreaseHunger()
    {
        hunger -= hungerDecreaseRate * Time.deltaTime;
        if (hunger < 0) hunger = 0;
    }

    void RegenerateHealth()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += healthRegenRate * Time.deltaTime;
        }
    }

    void CheckDeath()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died!");
        currentHealth = maxHealth; // Respawn health
        hunger = 100f; // Reset hunger
        transform.position = respawnPoint.position; // Respawn player
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
    }

    public void EatFood(float amount)
    {
        hunger += amount;
        if (hunger > 100) hunger = 100;
    }
}
