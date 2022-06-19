using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberController : MonoBehaviour, IInteractable{
    
    public Animator animator;
    
    public void Use(){
        GrabberGrab();
    }
    
    void GrabberGrab(){
        animator.SetTrigger("OnGrabberGrab");
        Debug.Log("Operating Grabber!");
    }

}
