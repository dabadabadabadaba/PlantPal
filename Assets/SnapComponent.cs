using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapComponent : MonoBehaviour
{
   public void TakeOwnership(DragAndSnap obj) 
   {
        obj.transform.parent = transform;
   }
}
