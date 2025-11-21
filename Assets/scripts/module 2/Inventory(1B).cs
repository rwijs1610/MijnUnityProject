using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<string> itemInventory = new List<string>();
    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            string itemName = collision.gameObject.name;
            itemInventory.Add(itemName);
            Debug.Log("Picked up: " + itemName);
            collision.gameObject.SetActive(false);
        }
    }

    
}
