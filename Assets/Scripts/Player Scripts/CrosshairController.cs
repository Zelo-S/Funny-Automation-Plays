using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour{
    
    public Canvas crosshair;

    void FixedUpdate(){
        UpdateCrosshair();
    }
    
    void UpdateCrosshair(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)){
            Debug.DrawLine(transform.position, hit.point);
        }
    }
    

}
