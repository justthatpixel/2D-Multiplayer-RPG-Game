using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item {

    public enum ItemType {
        Sword,
        HealthPotion,
        ManaPotion,
        coin,
        Medkit,
    }

    public ItemType itemType;
    public int amount;


   

}
