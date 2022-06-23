using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltController : MonoBehaviour{
    
    public float speed = 5.0f;
    public Transform endpoint;

    
    void OnTriggerStay(Collider other){
        if(other.CompareTag("Ground") || other.CompareTag("Player") || other.GetComponent<BeltController>() != null || other.GetComponent<GrabberController>() != null) return; // rework this blacklist system!
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, Time.deltaTime * speed);
    }

}
