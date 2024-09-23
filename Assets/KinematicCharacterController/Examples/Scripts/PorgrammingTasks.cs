using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PorgrammingTasks : MonoBehaviour
{
    
    
    [SerializeField] private int nummer1;
    [SerializeField] private int nummmer2;
    [SerializeField] private int n1;
    [SerializeField] private int n2;
   
    private enum Operation
    {
        Plus, Minus, Multiply , Divide 
    }

    [SerializeField] private Operation operation;
   
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("n1 + n2=" + (nummer1 + nummmer2));
        Debug.Log("n1 - n2=" + (nummer1 - nummmer2));
        Debug.Log("n1 * n2=" + (nummer1 * nummmer2));
        Debug.Log("n1 / n2=" + ((float)nummer1 / nummmer2));
        Debug.Log(operation.ToString()+ " " + CalculateNumber (nummer1, nummmer2).ToString(format:"F2"));
     
       
    }

   float CalculateNumber(int n1, int n2)
    {
        //switching with switch/case:
        switch (operation)
        {
          case  Operation.Plus:
              return n1 + n2;
          
          case Operation.Minus:
              return n1 - n2;
          
          case Operation.Multiply:
              return n1 - n2;
          
          case Operation.Divide:
              return (float)n1 / n2;
          
          default:
              return n1 * n2;
          
          
        }
        //switching witch if
        
    }







}
