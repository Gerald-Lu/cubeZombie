using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int newScene;

    // Update is called once per frame
    public void StartScene()
    {
        SceneManager.LoadScene(newScene);
    }
}
