using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour{
    
    public Canvas crosshair;
    private IInteractable hitObj;

    void Update(){
        ClickControl();
    }

    void FixedUpdate(){
        UpdateCrosshair();
    }
    
    void ClickControl(){
        if(Input.GetMouseButton(0)){
            hitObj?.Use();
        }
    }
    
    void UpdateCrosshair(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)){
            hitObj = hit.transform.gameObject.GetComponent<IInteractable>();
            Debug.DrawLine(transform.position, hit.point);
        }
    }
    

}
