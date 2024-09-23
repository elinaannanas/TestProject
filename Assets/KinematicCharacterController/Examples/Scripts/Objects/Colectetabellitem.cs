using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Colectetabeleitem" , menuName = "ScriptableObject/new Collectableitem")]
public class Colectetabeleitem : ScriptableObject
{
   public string nameItem = "";
   public int valueGold = 0;
   public Sprite imageSprite;
}
