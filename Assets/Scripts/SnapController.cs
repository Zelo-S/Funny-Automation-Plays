using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : Snapable, IInteractable{
    public void Use(){
        InstantiateAtSnapPoint();        
    }

    // TODO: Rewrite it so that the instantiatePosition works for non-square bases
    public override void InstantiateAtSnapPoint() {
        Vector3 instantiatePosition = closestSnapPoint.transform.position + closestSnapPoint.transform.forward / 2; 
        Debug.Log("making at: " + instantiatePosition);
        Instantiate(gameObject, instantiatePosition, Quaternion.identity);
    }
}
