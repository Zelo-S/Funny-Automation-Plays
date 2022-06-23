using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour{
    
    public List<GameObject> inventory;
    private GameObject previousActive;
    public GameObject currentActive;
    public GameObject armHoldObjectDisplayPos;
    
    void Update(){
        SelectInventoryItem();
    }
    
    // TODO: Toggling a key, vs highlighting until switched to another item
    void SelectInventoryItem(){
        
        // "activate inventory item
        if(Input.GetKeyDown(KeyCode.Alpha1)) SelectInventoryItem(1);            
        if(Input.GetKeyDown(KeyCode.Alpha2)) SelectInventoryItem(2);            
        if(Input.GetKeyDown(KeyCode.Alpha3)) SelectInventoryItem(3);            
        if(Input.GetKeyDown(KeyCode.Alpha4)) SelectInventoryItem(4);            
        if(Input.GetKeyDown(KeyCode.Alpha5)) SelectInventoryItem(5);            

    }
    
    void SelectInventoryItem(int index){
        --index; // use 0 indexing
        if(previousActive != null){
            previousActive.GetComponentInChildren<Image>().color = Color.white; // default back to original color
        }

        var inventoryImage = inventory[index].GetComponentInChildren<Image>();
        if(inventory != null){
            inventoryImage.color = Color.yellow;
            currentActive = inventory[index];
            UpdateDisplayedArmItem();            

            previousActive = currentActive;
        }
    }
    
    void UpdateDisplayedArmItem(){
        var inventoryItemGameObject = currentActive.GetComponent<InventoryItemController>().GetInventoryItem();
        if(armHoldObjectDisplayPos.transform.childCount != 0){
            foreach(Transform child in armHoldObjectDisplayPos.transform) Destroy(child.gameObject);
        }

        Debug.Log("Attempting instantiate"); 
        Instantiate(inventoryItemGameObject, armHoldObjectDisplayPos.transform);
    }

}
