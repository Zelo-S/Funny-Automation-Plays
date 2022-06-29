using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour{
    
    public Canvas crosshair;
    public GameObject hitObj;
    private IInteractable hitInteractable;
    private Snapable hitSnapable;
    
    void Update(){
        ClickControl();
    }

    void FixedUpdate(){
        UpdateCrosshair();
    }
    
    void ClickControl(){
        if(Input.GetMouseButton(0)){
            // Debug.Log("Hit the: " + hitObj);
            hitInteractable?.Use();
        }
    }
    
    void UpdateCrosshair(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)){
            hitObj = hit.transform.gameObject;
            hitInteractable = hitObj.GetComponentInChildren<IInteractable>();
            hitSnapable = hitObj.GetComponentInChildren<Snapable>();

            if(hitSnapable != null) Snap(hit);

            Debug.DrawLine(transform.position, hit.point);
        }
    }
    
    void Snap(RaycastHit hit){
        hitSnapable?.SnapToPoint(hit);
    }

}
