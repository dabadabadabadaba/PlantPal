using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexDraggable : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Plant;

    private bool isDragging;
    public Vector2 startPosition;

        public void OnMouseDown()
        {
            isDragging = true;
            startPosition = transform.position;
            
        }

        public void OnMouseUp() 
        {   
            // //will send the object back to starting position
            // transform.position = startPosition;
            
            // RaycastHit2D[] hits;
            Collider2D[] hits;
            hits = Physics2D.OverlapPointAll(transform.position);
            Debug.Log(hits.Length);
            Debug.Log(startPosition);

            foreach(var obj in hits)
            {
                try
                {
                    Collider2D foundComponent = obj.GetComponent<Collider2D>();
                    Debug.Log(foundComponent.tag);
                    Debug.Log(foundComponent.name);
                    // foundComponent.TakeOwnership(this);
                    // return;
                }

                catch
                {
                    //no component found
                }

            }
            Debug.Log("Setting parent to plant");
            isDragging = false;
            transform.SetParent(Plant.transform);
        }

        // private void OnTriggerEnter2D(Collider2D other) 
        // {
        //     if (other.tag == "Panel") 
        //     {
        //         Debug.Log("Add item back to menu");
        //         transform.SetParent(Panel.transform);
        //     }
	    // }

        void Update() 
        {
            if (isDragging)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
        }
}
