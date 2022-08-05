using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public int SceneIndex;

    // Update is called once per frame
    void OnTriggerStay()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
