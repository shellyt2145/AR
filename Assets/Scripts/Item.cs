using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public int itemID;
    public Texture2D itemIcon;

    public Item(string name, int id)
    {
        itemName = name;
        itemID = id;
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
    }
    public Item()
    { }
}