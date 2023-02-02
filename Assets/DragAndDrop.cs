using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public delegate void DragEndedDelgate(DragAndDrop draggableObject);
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
