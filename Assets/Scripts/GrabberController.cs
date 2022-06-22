using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GrabberController : MonoBehaviour{
    
    public Animator animator;
    public Transform capturePos;

    public GameObject otherObj;
    
    void OnTriggerEnter(Collider other){
        otherObj = other.gameObject;
        var grab = otherObj.GetComponent<IGrabable>();
        grab?.MoveSpot(capturePos.transform);
        GrabberGrab();
    }
    
    public void GrabberGrab(){
        animator.SetBool("IsGrabPosOccupied", true);
        animator.SetTrigger("OnObjectDetected");
    }
    
    // TODO: check if the drop spot is unoccupied
    void GrabberDrop(){
        if(otherObj != null){
            Debug.Log("Dropping");
            var grab = otherObj.GetComponent<IGrabable>();
            grab?.DropSpot(this.transform);
            
            GrabberDeactivate();
        } 
    }
    
    public void GrabberDeactivate(){
        animator.SetBool("IsGrabPosOccupied", false);
    }

}
