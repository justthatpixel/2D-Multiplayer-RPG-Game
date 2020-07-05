using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory Inventory;
    public GameObject itemButton;
    public GameObject Player;
  
    

    private void Start()
    {
        Inventory = Player.GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject==Player)

        {

            for (int i = 0; i < Inventory.slots.Length; i++)
            {
                if (Inventory.isFull[i] == false)
                {
                    Inventory.isFull[i] = true;
                    Instantiate(itemButton, Inventory.slots[i].transform, false);
                    Destroy(gameObject);

                    break;
                }

            }

        }
    }


}
             
    
    
          
