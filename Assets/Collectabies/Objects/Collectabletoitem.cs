using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectabletoitem : MonoBehaviour
{
    [SerializeField] private GameObject toolTip;
    [SerializeField] private Colectetabeleitem itemData;
    private Transform transformCamera;

    private bool isInInteractionRange = false;

    
    // Start is called before the first frame update
    void Start()
    {
        toolTip.SetActive((false));
        if (Camera.main != null) transformCamera = Camera.main.transform;
    }


    private void Update()
    {
        if (isInInteractionRange)
        {
            toolTip.transform.LookAt(transformCamera);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerEntered");
            toolTip.SetActive(true);
            isInInteractionRange = true;
            
            //Add Item to the List for items that can be collected
            ItemMangerer.Instance.AddItemCollectable(this);

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerLeft");
            toolTip.SetActive(false);
            isInInteractionRange = false;
            
            ItemMangerer.Instance.RemoveItemCollectable(this);

        }
    }
}
