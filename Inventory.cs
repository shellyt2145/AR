using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int slotsX, slotsY;
    public GUISkin skin;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();
    private ItemDatabase database;
    public bool showInventory;
  

    private void Start()
    {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Item());
        }
    

        database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
        
        
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            showInventory = !showInventory;
        }
    }
    void OnGUI()
    {
        GUI.skin = skin;
        if (showInventory)
        {
            DrawInventory();
        }
        //for(int i = 0; i < inventory.Count; i++)
        //{
        //    GUI.Label(new Rect(5, i * 50, 50, 35), inventory[i].itemName);
        //}
    }

    void DrawInventory()
    {
        int i = 0;
        for (int x = 0; x < slotsX; x++)
        {
            for(int y = 0; y < slotsY; y++)
            {
                Rect slotRect = new Rect(x * 50, y * 50, 50, 50);
                GUI.Box(slotRect, "", skin.GetStyle("Slot"));
                //slots[i] = inventory[i];
                if (slots[i].itemName != null)
                {
                    GUI.DrawTexture(slotRect, slots[i].itemIcon);
                }

                i++;
            }
        }
    }
    

}

