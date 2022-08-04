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
    public AudioClip HitMarkerSound;
    AudioSource HitMarker;

    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        healthBar.maxHealthEnemy(enemyMaxHealth);

        HitMarker = AddAudio();
        HitMarker.clip = HitMarkerSound;
    }

    public AudioSource AddAudio()
    {
        AudioSource newAudio = gameObject.AddComponent<AudioSource>();
        return newAudio;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            HitMarker.Play();
           DamageTick(20);
           Debug.Log("hit enemy"); 
        }
        
    }
    public void DamageTick (int damage){
        enemyCurrentHealth -= damage;
        healthBar.SetEnemyHealth(enemyCurrentHealth);
        if (enemyCurrentHealth <= 0)
        {
            HitMarker.Play();
            Destroy(this.gameObject);
        }
    }
}
