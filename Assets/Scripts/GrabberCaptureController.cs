using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberCaptureController : MonoBehaviour{
    
    void OnTriggerEnter(Collider other){
        var otherObj = other.gameObject.GetComponent<IGrabable>();
        otherObj?.MoveSpot(this.transform);
    }

}
