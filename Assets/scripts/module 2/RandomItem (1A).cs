using System;
using UnityEngine;

public class RandomItem : MonoBehaviour
{

    [SerializeField] private string[] itemName = new string[10]; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.Escape))PrintAllItems();
    }
    private void PrintRandomItem() {
        int randomIndex = UnityEngine.Random.Range(0, itemName.Length);
        Debug.Log("enter was pressed!");
        Debug.Log("Random Item: " + itemName[randomIndex]);

    }
    private void PrintAllItems() {
        Debug.Log("escape was pressed!");
        Debug.Log("All Items:");
        foreach (string item in itemName) {
            Debug.Log(item);
       
    }
    }
}
