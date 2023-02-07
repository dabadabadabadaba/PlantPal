using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexDraggable : MonoBehaviour
{
    public GameObject Panel;
    private bool isDragging;

        public void OnMouseDown()
        {
            isDragging = true;
        }

        public void OnMouseUp() 
        {   Debug.Log("Setting parent to null");
            isDragging = false;
            transform.SetParent(null);
        }

        private void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "Panel") 
            {
                Debug.Log("Add item back to menu");
                transform.SetParent(Panel.transform);
            }
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
