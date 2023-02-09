using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDraggable : MonoBehaviour
{
    public GameObject Panel;
    public GameObject SnapPoint;
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
            
            Collider2D[] hits;
            hits = Physics2D.OverlapPointAll(transform.position);
            Debug.Log(hits.Length);
            Debug.Log(startPosition);

            foreach(var obj in hits)
            {
                Collider2D foundComponent = obj.GetComponent<Collider2D>();
                Debug.Log(foundComponent.tag);
                Debug.Log(foundComponent.name);

                if (foundComponent.tag == "SnapPoint")
                {
                    Debug.Log("Setting parent to SnapPoint");
                    // transform.SetParent(SnapPoint.transform); //based on object in inspector
                    //transform.SetParent to found object
                    transform.SetParent(foundComponent.gameObject.transform);
                    // transform.localPosition = new Vector3(0,0,0);
                    Debug.Log(SnapPoint.transform.localPosition);
                    transform.position = foundComponent.gameObject.transform.position;

                }

                if (foundComponent.tag == "Panel")
                {
                    Debug.Log("Setting parent to panel");
                    transform.SetParent(Panel.transform);
                    // transform.position = Panel.transform.localPosition;
                }

                else
                {
                    // transform.position = startPosition;
                }

            }

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