using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_inventory :ScriptableObject
{
    private Inventory inventory;
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }
}
