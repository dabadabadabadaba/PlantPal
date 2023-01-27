using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isSelected;

        public void OnMouseDown()
        {
            isSelected = true;
        }

        public void OnMouseUp() 
        {
            isSelected = false;
        }

        void Update() 
        {
            if (isSelected)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
        }
}
