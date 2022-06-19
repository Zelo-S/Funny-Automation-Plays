using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberController : MonoBehaviour, IInteractable{
    
    public Animator animator;
    
    public void Use(){
        Debug.Log("Hello");
    }
    
    void GrabberGrab(){
        animator.SetTrigger("OnGrabberGrab");
    }

}
