using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpener : MonoBehaviour
{
    public GameObject OpenWindow;
    public GameObject ClosedWindow;


    public void OpenCurtain()
    {
        if (OpenWindow != null)
        {
            bool openActive = OpenWindow.activeSelf;
            OpenWindow.SetActive(!openActive);

            bool closedActive = ClosedWindow.activeSelf;
            ClosedWindow.SetActive(!closedActive);
        }

    }
}
