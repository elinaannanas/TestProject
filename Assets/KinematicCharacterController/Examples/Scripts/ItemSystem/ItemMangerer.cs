using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMangerer : MonoBehaviour
{
    
        
    public static ItemMangerer Instance {get; private set; }
   
        
        
   
    [SerializeField] private Colectetabeleitem[] items;

    private void Start()
    {
        Debug.Log(items[0].nameItem + "kostet" + items[0].valueGold + "Gold");
        Debug.Log(items[1].nameItem + "kostet" + items[1].valueGold + "Gold");

        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log(items[i].nameItem + "kostet" + items[i].valueGold + "Gold");
            
        }

        int j = 0;

        while ( j< items.Length)
        {
            Debug.Log(items[j].nameItem + "kostet "+ items[j].valueGold + "Gold");
        }

        foreach (Colectetabeleitem item in items)
        {
           Debug.Log(item.nameItem + "kostet" + item.valueGold + "Gold"); 
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
           
        }
        
    }
    public void AddItemCollecta
    
    
    
    
}
