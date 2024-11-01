using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{

   
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCubes());
        


    }

    IEnumerator SpawnCubes()
    {
        int counter = 0;
        
                for (int i = 0; i < 120; i++)
                {
                    counter = counter + 1;
                    Debug.Log(counter);
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(0,  5f, counter);
                    cube.transform.eulerAngles = new Vector3(0, 0, 0);

                    StartCoroutine(RotateCube(cube.transform));
        
                    


                    yield return new WaitForSeconds(0.1f);
                }
        
        
        
    }

    IEnumerator RotateCube(Transform transformCube)
    {
        float angle = 0;
        while (true)
        {
            angle = angle + Time.deltaTime;
            transformCube.eulerAngles = new Vector3(100*angle, 100*angle, 0f);
            yield return null; // wartet bis zum nächsten Frame 
        }


    }



}
