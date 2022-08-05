using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveCompleteScript : MonoBehaviour
{
    public bool Complete;
    public string TextComplete;
    public bool Done;
    public TextMeshProUGUI Text;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && Done == false)
        {
            Complete = true;
            Text.text = TextComplete.ToString();
            StartCoroutine("WaitForSec");
            transform.Translate(new Vector3(1000,0,0));
        }
    }
    void Start()
    {
        Text = Text.GetComponent<TextMeshProUGUI>();
        Done = false;
    }
    public IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Text.text = "Go to Central Computer";
        Done = true;
        Debug.Log("worked");
    } 
}

