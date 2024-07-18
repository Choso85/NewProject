using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public string itemName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Inventory inventory = other.GetComponent<Inventory>();
            if (inventory != null)
            {
                inventory.AddItem(itemName);
            }
            Destroy(gameObject);
        }
    }
}