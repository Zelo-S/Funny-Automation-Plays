using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour{
    
    public SOInventoryItem inventoryItem;
    
    public GameObject GetInventoryItem(){
        return inventoryItem.itemGO;
    }

}
