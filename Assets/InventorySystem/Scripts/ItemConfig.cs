using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InventorySystem/ItemConfig", fileName = "NewItemConfig")]
public class ItemConfig :ScriptableObject {
    public new string name;
    public Sprite defaultImage;
}