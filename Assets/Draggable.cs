using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Oxmond Tutorial

public class Draggable : MonoBehaviour
{
    private bool isDragging;

        public void OnMouseDown()
        {
            isDragging = true;
        }

        public void OnMouseUp() 
        {
            isDragging = false;
        }

        void Update() 
        {
            if (isDragging)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
        }
}
