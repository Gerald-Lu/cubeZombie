using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExitS : MonoBehaviour
{
    public ObjectiveTrigger2 ObjectiveTwo;
    void Start()
    {

        ObjectiveTwo = GameObject.FindObjectOfType<ObjectiveTrigger2>();
    
    }

    
}
