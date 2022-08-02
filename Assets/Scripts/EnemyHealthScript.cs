using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthScript : MonoBehaviour
{
    public int enemyMaxHealth = 100;
    public int enemyCurrentHealth;
    public EnemyHealth healthBar;
    public Slider enemySlider;
    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        healthBar.maxHealthEnemy(enemyMaxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
           DamageTick(20);
           Debug.Log("hit enemy"); 
        }
        
    }
    void DamageTick (int damage){
        enemyCurrentHealth -= damage;
        healthBar.SetEnemyHealth(enemyCurrentHealth);
        if (enemyCurrentHealth <= 0){
            Destroy(this.gameObject);
        }
    }
}
