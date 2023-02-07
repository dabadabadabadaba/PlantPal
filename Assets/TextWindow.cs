using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWindow : MonoBehaviour
{
    [SerializeField] GameObject UiObject;
    [SerializeField] GameObject OpenedWindow;
    
    void Start()
        {
            UiObject.SetActive(false);
        }

        void OnTriggerEnter2D(Collider2D other)
        { 
            if (other.tag == "Plant")
            {
                UiObject.SetActive(true);
            }
        }

        void OnTriggerExit2D(Collider2D other) {
            UiObject.SetActive(false);
        }
}
