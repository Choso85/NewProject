using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> items = new List<string>();
    public void AddItem(string itemName)
    {
        items.Add(itemName);
        Debug.Log("Added to inventory: " + itemName);
    }
    public void ShowInventory()
    {
        Debug.Log("Inventory contains:");
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }
}
