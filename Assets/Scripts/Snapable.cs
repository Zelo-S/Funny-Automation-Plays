using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// quick comment: I dont really know why im using an abstract here lol
public class Snapable : MonoBehaviour, IInteractable{
    
    public List<GameObject> snapPoints;
    public GameObject snapPointIndicator;
    public GameObject closestSnapPoint;
    private GameObject previousSnapPoint;
    

    public void SnapToPoint(RaycastHit hit){
        closestSnapPoint = snapPoints[0];
        foreach(GameObject snapPoint in snapPoints){
            float curr_distance = Vector3.Distance( hit.point, snapPoint.transform.position );
            if( Vector3.Distance(hit.point, closestSnapPoint.transform.position) > curr_distance ) closestSnapPoint = snapPoint;
        }


        // now we have shortest distance to snapPoint
        if(!closestSnapPoint.Equals(previousSnapPoint)) {
            Instantiate(snapPointIndicator, closestSnapPoint.transform);
            if(previousSnapPoint == null) previousSnapPoint = closestSnapPoint;
            else if(previousSnapPoint.transform.childCount != 0) foreach(Transform child in previousSnapPoint.transform) Destroy(child.gameObject);
        }
        
        previousSnapPoint = closestSnapPoint;
    }

    public void Use(){
        InstantiateAtSnapPoint();        
    }

    public void InstantiateAtSnapPoint() {
        Vector3 instantiatePosition = gameObject.transform.position + closestSnapPoint.transform.forward; 
        Debug.Log("making at: " + instantiatePosition);
        Instantiate(gameObject, instantiatePosition, Quaternion.identity);
    }

}
