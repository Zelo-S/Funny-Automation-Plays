using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Snapable : MonoBehaviour{
    
    public List<GameObject> snapPoints;
    public GameObject snapPointIndicator;
    private GameObject previousSnapPoint;

    public void SnapToPoint(RaycastHit hit){
        GameObject closestSnapPoint = snapPoints[0];
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

}
