using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour{
    
    public Canvas crosshair;
    public GameObject hitObj;
    public GameObject prevHitObj;
    private IInteractable hitInteractable;
    private Snapable hitSnapable;
    
    void Update(){
        ClickControl();
    }

    void FixedUpdate(){
        UpdateCrosshair();
    }
    
    void ClickControl(){
        if(Input.GetMouseButtonDown(0)){
            // Debug.Log("Hit the: " + hitObj);
            hitInteractable?.Use();
        }if(Input.GetMouseButtonDown(1)){
            hitSnapable?.WipeSnapPoints(); 
        }
    }
    
    void UpdateCrosshair(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)){
            hitObj = hit.transform.gameObject;
            HandleSnapClearing();

            hitInteractable = hitObj.GetComponentInChildren<IInteractable>();
            hitSnapable = hitObj.GetComponentInChildren<Snapable>();
            
            if(hitSnapable != null){ 
                Snap(hit);
            }

            Debug.DrawLine(transform.position, hit.point);
        }
    }
    void Snap(RaycastHit hit){
        hitSnapable?.SnapToPoint(hit);
    }
    
    void HandleSnapClearing(){
        if(!hitObj.Equals(prevHitObj)){
            Debug.Log(hitObj + " versus " + prevHitObj);
            if(prevHitObj == null){
                prevHitObj = hitObj;
            }else{
                var prevHitSnapable = prevHitObj.GetComponentInChildren<Snapable>();
                hitSnapable?.WipeSnapPoints();
            }
        }
        prevHitObj = hitObj;
    }
}
