using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GrabberController : MonoBehaviour, IInteractable{
    
    public Animator animator;
    
    void Awake(){
    }
    
    public void Use(){
        AnimateGrabber();
    }
    
    void AnimateGrabber(){
        GrabberGrab();
    }
    
    void GrabberGrab(){
        animator.SetTrigger("OnGrabberGrab");
    }
    
    // TODO: check if the drop spot is unoccupied
    void GrabberDrop(){
        animator.SetTrigger("OnGrabberDrop");
    }

}
