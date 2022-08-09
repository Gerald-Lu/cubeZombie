using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "gun")
        {
            if(other.gameObject.tag != "collider")
            {
                Destroy(this.gameObject);
                Debug.Log("hit"); 
            }
        }
        
    }
}
