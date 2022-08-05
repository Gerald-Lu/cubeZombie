using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInteract : MonoBehaviour
{
    public bool enemyDoor;
    public bool finished;
    public bool finishedNon;
    public bool finalDoor;
    public ObjectiveTrigger2 ObjectiveTwo;
    Animator doorA;
    void OnTriggerEnter(Collider other){
        if (ObjectiveTwo.finished2 || finishedNon){
            if (finalDoor || finishedNon){
                if (other.gameObject.tag == "Player")doorA.SetBool("opened", true);
            }

            if (enemyDoor && other.gameObject.tag == "Enemy")doorA.SetBool("opened", true);
        }
 
    }
    void OnTriggerExit(Collider other){
        doorA.SetBool("opened", false);
    }
    void Start()
    {
        doorA = this.transform.parent.GetComponent<Animator>();

        ObjectiveTwo = GameObject.FindObjectOfType<ObjectiveTrigger2>();
    
    }

}
