using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextForObject : MonoBehaviour
{
    public GameObject TextObject;
    [SerializeField] GameObject GameObject;

    void Start()
    {
        TextObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.tag == "Plant")
        {   
            Debug.Log("Text for this object should display");
            TextObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        TextObject.SetActive(false);
    }
}
