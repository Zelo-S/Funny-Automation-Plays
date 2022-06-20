using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjController : MonoBehaviour, IGrabable {
    
    public void MoveSpot(Transform parentGO){
        Debug.Log("Moving test obj!");
        transform.parent = parentGO.transform;
        transform.position = parentGO.transform.position;
        transform.localRotation = Quaternion.identity; 
    } 
    
    public void DropSpot(){
        transform.parent = null;
    }

}
