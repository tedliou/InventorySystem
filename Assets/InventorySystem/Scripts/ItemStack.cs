using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InventorySystem/ItemStack", fileName = "NewItemStack")]
public class ItemStack :ScriptableObject {
    public List<ItemConfig> itemConfigs;
}