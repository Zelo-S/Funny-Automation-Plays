using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour{
    
    public List<GameObject> inventory;
    
    void Update(){

    }
    
    void SelectInventoryItem(){
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            Debug.Log("Selected First Item!");
        }
    }

}
