using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndSnap : MonoBehaviour
{
    public delegate void DragEndedDelgate(DragAndSnap draggableObject);
    public DragEndedDelgate dragEndedCallback;

    private bool isDragging;

        public void OnMouseDown()
        {
            isDragging = true;
        }

        public void OnMouseUp() 
        {
            isDragging = false;
            dragEndedCallback(this);
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