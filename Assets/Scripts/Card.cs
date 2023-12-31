using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int level;
    public int attack;
    public int defense;
    
    public void Print()
    {
        Debug.Log(name + ": " + description + " This card level is: " + level);
    }
}
