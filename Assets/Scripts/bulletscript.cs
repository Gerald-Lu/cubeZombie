using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag != "pistol" || this.gameObject.tag != "Bullet")
        {
           Destroy(this.gameObject);
            Debug.Log("hit"); 
        }
        
    }
}
