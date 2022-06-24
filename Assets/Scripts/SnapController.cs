using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour, IInteractable{
    
    public List<GameObject> snapPoints;
     
    public void Use(RaycastHit hitPoint){
        SnapToPoint();
    }
    
    void SnapToPoint(){
        
    }

}
