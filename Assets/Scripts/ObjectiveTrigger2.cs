using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveTrigger2 : MonoBehaviour
{
    public GameObject ObjectiveTextObject;
    public TextMeshProUGUI ObjectiveText;
    public bool donePrevious;
    public bool finished2;
    [SerializeField] public string Description;
    [SerializeField] public bool Complete;
    
    public GameObject CompletedText;
    public ObjectiveCompleteScript ObjectiveOne;
    // Start is called before the first frame update
    void Start()
    {
        Complete = false;
        ObjectiveText = ObjectiveText.GetComponent<TextMeshProUGUI>();
        ObjectiveText.text = Description.ToString();
        ObjectiveTextObject.SetActive(false);
        CompletedText.SetActive(false);
        ObjectiveOne = GameObject.FindObjectOfType<ObjectiveCompleteScript>();


    }
    void Update(){
        donePrevious = ObjectiveOne.Done;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && donePrevious)
        {
            Complete = true;
            ObjectiveTextObject.SetActive(true);
            CompletedText.SetActive(true);
            ObjectiveText.text = "Survive for 30 seconds";
            Debug.Log("fixedTrigger2");
            StartCoroutine("WaitForSec");

        }
        
    }

    public IEnumerator WaitForSec()
        {
            yield return new WaitForSeconds(30);
            ObjectiveText.text = "Files Export Complete";
            Debug.Log("Being called");
            finished2 = true;
            Debug.Log(finished2);
            
            
        }
}
