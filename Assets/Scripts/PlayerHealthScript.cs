using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealthScript : MonoBehaviour
{
    //Berries (gonna start calling varibles berries because it sounds good)
    public int maxHealth = 100;
    public int currentHealth;
    
    public HealthBarScript healthBar;
    double timePassed;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        timePassed = 0;
    }

    // Update is called once per frame
    private void OnCollisionStay (Collision collision)
    {
        timePassed = timePassed + Time.deltaTime;
        if (collision.collider.gameObject.CompareTag("Enemy") && timePassed >= 1)
        {
            TakeDamage(10);
            Debug.Log("Hit Enemy");
            timePassed = 0;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0){
            SceneManager.LoadScene(5);
        }
    }
}