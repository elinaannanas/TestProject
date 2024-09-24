using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectabletoitem : MonoBehaviour
{
    [SerializeField] private GameObject toolTip;
    private Transform tranformCamera;
    
    private bool isInInter

    [SerializeField] private SO_Collectableitem itemData;
    // Start is called before the first frame update
    void Start()
    {
        toolTip.SetActive((false));
    }


    private void Update()
    {
        if (isInteractionRange)
        {
            
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerEntered");
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerLeft");
        }
    }
}
