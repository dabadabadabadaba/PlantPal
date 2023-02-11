using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject WelcomeText;

    private void Start() {
        WelcomeText.SetActive(true);
    }
    
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            WelcomeText.SetActive(false);
        }
    }
}
