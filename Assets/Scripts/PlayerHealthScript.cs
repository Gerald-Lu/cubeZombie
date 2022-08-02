using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    //Berries (gonna start calling varibles berries because it sounds good)
    public int maxHealth = 100;
    public int currentHealth;
    
    public HealthBarScript healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(5);
            Debug.Log("Hit");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}