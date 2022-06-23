using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Inventory Item", fileName = "New SO Inventory Item")]
public class SOInventoryItem : ScriptableObject{
    
    public int index;
    public int amount; 
    public GameObject itemGO;
    public Sprite itemImage;

}
