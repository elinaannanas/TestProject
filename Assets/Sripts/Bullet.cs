using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 5f;

    private void Start()
    {
        transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0, 360));
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * speed;
    }

    private void ConcollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Planet"))
        {
           Destroy(other.gameObject);
           if (bounces > 0)
           {
               rb.velocity = Vector3.Reflect(rb.velocity, other.GetContact(0).normal);
               bounces--;

           }
        }
        
        
    }

   
}