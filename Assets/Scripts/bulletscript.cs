using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag != "gun")
        //{
           Destroy(this.gameObject);
           Debug.Log("hit"); 
        //}
        
    }
}
