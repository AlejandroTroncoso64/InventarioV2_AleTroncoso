using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class InventorySystem : MonoBehaviour
{
    //Crear lista de items en el inventario
    public List<Item> items = new List<Item>();

    //Añadir items
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    
    //Quitar items
    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}

