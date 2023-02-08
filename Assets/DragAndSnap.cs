using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// //attempt at what Harrison suggested
// //should be possible to combine the snap point with reassinging gameObject parents

// public class DragAndSnap : MonoBehaviour
// {
// 	public Camera camera;
	
// 	public void OnMouseUp()
// 	{
// 		RaycastHit[] hits;
// 		var objectsHit = Physics.RaycastAll();

// 		foreach(var obj in objectsHit);
// 		{
// 			try
// 			{
// 				var foundComponent = obj.GetComponent<SnapComponent>();
// 				foundComponent.TakeOwnership(this);
// 				return;
// 			}

// 			catch
// 			{
// 				//no component found
// 			}
// 		}


// 		// Raycast from mouse point
// 		// will return list of game objects
//         // get component 
//         // get snapcomponent 

// 		// var objectsHit = Raycast();

// 		// foreach(var obj in objectsHit)
// 		// {
// 		// 	try
// 		// 	{
// 		// 		var foundComponent = obj.GetComponent<SnapComponent>();
// 		// 		foundComponent.TakeOwnership(this);
// 		// 		return;
// 		// 	}
// 		// 	catch
// 		// 	{
// 		// 		// no component found
// 		// 	}
// 		// }
// 	}
// }
