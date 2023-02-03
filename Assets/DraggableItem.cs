using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Curious Bits Tutorial 
//JUST Dragging Logic

public class DraggableItem : MonoBehaviour 
{   
    //defining a delegate of type void with a draggable object parameter
    //a delegate is a reference type that holds a reference to a method
    public delegate void DragEndedDelegate(DraggableItem draggableObject);

    //public variable with the delegate type, named "dragEndedCallback"
    //want to involve this callback once the drag is over
    public DragEndedDelegate dragEndedCallback;
    
    private bool isDragged = false; //keeps track of sprite state
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    //invoked when user presses down on left mouse button
    private void OnMouseDown() {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //saving the current mouse position to mouseDragStartPosition variable
        spriteDragStartPosition = transform.localPosition; //saving current sprite position to variable
    }

    //invoked when user moves mouse while still pressing left mouse button
    //updates sprite position by taking the difference between where the mouse is and mouseDragStartPosition
    //and adding that difference to the spriteDragStartPosition
    private void OnMouseDrag() {
        if (isDragged) {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition)- mouseDragStartPosition);
        }

    }
    // invoked when user releases left mouse button
    private void OnMouseUp() {
        isDragged = false;
        dragEndedCallback(this); //"this" is a reference to the current draggable object
    }
    
}

