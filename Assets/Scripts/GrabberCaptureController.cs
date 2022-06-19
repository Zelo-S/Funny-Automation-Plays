using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberCaptureController : MonoBehaviour{
    
    private BoxCollider capture;
    
    void Awake(){
        capture = GetComponent<BoxCollider>();
    }

}
