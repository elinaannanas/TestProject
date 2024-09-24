using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class List : MonoBehaviour
{
   [SerializeField] private string[] animals;
   [SerializeField] private string[] animallist;
   [SerializeField] private int animalCountIlist;
    void Start()
   {
      Debug.Log("Start counting" + animals[0]);

      int animalsFound = 0;

      foreach (string animal in animals)
      {
         if (animal == animals[0])
         {
            animalsFound++;
         }
      }

      Debug.Log(("We found" + animalsFound + " " + animals[0]));
      
      
      

         animallist = new string[animalCountIlist];
      animallist[0] = animals[Random.Range(0, animals.Length)];

      for (int i = 0; i <animallist.Length ; i++)
      {
         animallist[i] = animals[Random.Range(0, animals.Length)];
      }






   }
   
   
   
   
   

}












