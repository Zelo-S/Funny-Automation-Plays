using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGrabable : MonoBehaviour {
    
    public void MoveSpot(Transform parent){
        Debug.Log("Moving test obj!");
        transform.parent = parent.transform;
        transform.position = parent.transform.position;
        transform.localRotation = Quaternion.identity; 
    }

    public void DropSpot(Transform parent){
        Debug.Log("Dropping object!");
        parent.DetachChildren();
    }

}
