using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("Gnome 1", 1));
        items.Add(new Item("Gnome 2", 2));
        items.Add(new Item("Gnome 3", 3));
    }





}
