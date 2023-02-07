using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWater : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject Water;

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
