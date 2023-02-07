using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpener : MonoBehaviour
{
    public GameObject OpenWindow;

    public void OpenCurtain()
    {
        if (OpenWindow != null)
        {
            bool isActive = OpenWindow.activeSelf;
            OpenWindow.SetActive(!isActive);
        }
    }
}
