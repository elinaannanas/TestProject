using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    Plane plane = new Plane(Vector3.forward, 0);

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPosition = Vector3.zero;
        float distance;
        
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
        transform.LookAt(worldPosition);
        
        

        if (Input.GetMouseButtonDown(0))
        {
            GameObject ob = Instantiate(bullet, transform.position + transform.forward*0.6f, transform.rotation);
            ob.transform.up = transform.forward;
        }
    }
}