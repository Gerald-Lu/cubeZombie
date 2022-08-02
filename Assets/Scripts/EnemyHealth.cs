using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider enemySlider;
    public void maxHealthEnemy (int health){
        enemySlider.maxValue = health;
        enemySlider.value = health;
    }
    // Start is called before the first frame update
    public void SetEnemyHealth (int health){
        enemySlider.value = health;

    }
}
