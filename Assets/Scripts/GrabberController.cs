using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GrabberController : MonoBehaviour{
    
    public Animator animator;
    public BoxCollider grabPos;
    public BoxCollider dropPos;
    public IGrabable otherObj{ get; set; }
    
    void OnTriggerEnter(Collider other){
        otherObj = other.gameObject.GetComponent<IGrabable>();
        otherObj?.MoveSpot(this.transform);

        // Animate Grabber
        GrabberGrab();
    }
    
    public void GrabberGrab(){
        animator.SetTrigger("OnObjectDetected");
    }
    
    // TODO: check if the drop spot is unoccupied
    void GrabberDrop(){
        Debug.Log("Dropping object!");
        // unparent the currently held item
        otherObj?.DropSpot();    
    }

}
