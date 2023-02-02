using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<DragAndSnap> draggableObjects;
    public float snapRange = 0.5f;


    void Start()
    {
        foreach(DragAndSnap draggable in draggableObjects){
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded(DragAndSnap draggable){
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoint in snapPoints){
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance){
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }
        if (closestSnapPoint != null && closestDistance <= snapRange) {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
