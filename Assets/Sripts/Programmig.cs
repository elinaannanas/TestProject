using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Programmig : MonoBehaviour
{
    
    [SerializeField] private int rootnumber = 2;
    [SerializeField] private int powernumber = 5;

    [SerializeField] private Button ButtonCaculate;

    [SerializeField] private GameObject prefactPlanet;
    [SerializeField] private Transform parentPlanet;
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonCaculate.onClick.AddListener( () =>
        {
            int result = PowerOf(rootnumber, power: powernumber);
            
            Debug.Log(result);

            foreach (Transform planet in parentPlanet)
            {
                Destroy(planet.GameObject());
            }
              
            
            for (int i = 0; i <PowerOf(rootnumber, powernumber); i++)
                {
                     Vector3 randomPostionen = new Vector3(x:Random.Range(-5,5f),y:Random.Range(-1f,10f),z:0f);
                               CreateObjects(randomPostionen);
                    
                }

          
            
        });
       
    }
    
    //Funktion, welche die Square2 von einen Wert zurückgibt


    int PowerOf(int root, int power)
    {
        return Mathf.RoundToInt(Mathf.Pow(rootnumber, powernumber));


    }

   

    void CreateObjects(Vector3 newPosition)
    {
        GameObject newPlanet = Instantiate(prefactPlanet,parentPlanet);
        newPlanet.transform.position = newPosition;
    }
    
    
    
  

}
