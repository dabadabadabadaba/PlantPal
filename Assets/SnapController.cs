using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Curious Bits Tutorial 
//Snap logic

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<DraggableItem> draggableObjects;
    public float snapRange = 0.5f;


    void Start()
    {
        //looping over draggable objects and then assigning the onDragEnded method to the dragEndedCallback
        foreach(DraggableItem draggable in draggableObjects){
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    //new private method OnDragEnded with a parameter of type "draggable"
    //method finds the snapPoint that is closest to the draggable
    //if the distance is smaller than the snapRange, the position of the draggable is updated
    private void OnDragEnded(DraggableItem draggable){
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        //iterate over list of snapPoints and calculate the distance between the draggable object and the current snapPoint
        foreach(Transform snapPoint in snapPoints){
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition); //getting the distance between two vectors using built-in method .Distance
            //if the closestSnapPoint is null or the distance 
            //is smaller than the previous closest distance, 
            //update the variables
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {   
                Debug.Log("Calculating closest snapPoint");
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }
        //outside the loop, check if closestSnapPoint is not null and the closestDistance is smaller or equal to the snapRange
        if (closestSnapPoint != null && closestDistance <= snapRange) 
        // if true, change the draggable object position to the closestSnapPoint position
        {
            Debug.Log("Snap!");
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
