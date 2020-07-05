using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory Inventory;
    public GameObject player;
    public int i;

    /*   DOES NOT WORK. INVENTORY. TO CHECK IF INVENTORY IS FULL, SO NEW ITEMS CAN BE PLACED.
    private void Start()
    {
        Inventory = player.GetComponent<Inventory>();
    }
    private void Update()
    {
        if (transform.childCount <= 1)
        {
            Inventory.isFull[i] = false;
        }
    }
    */
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
