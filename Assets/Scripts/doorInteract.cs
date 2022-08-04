using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInteract : MonoBehaviour
{
    Animator doorA;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")doorA.SetBool("opened", true);
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player")doorA.SetBool("opened", false);
    }
    void Start()
    {
        doorA = this.transform.parent.GetComponent<Animator>();
    }

}
