using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
     public InventorySystem inventory;
    public Slots[] slots; //Slots asignables en inspector

    public void AddItemButton1()
    {
        //Bot�n para crear un nuevo item
        ItemDiamondSword newItem = new ItemDiamondSword();

        //A�adir item al inventario
        inventory.AddItem(newItem);

        //Actualizar la interfaz de usuario
        UpdateInventoryUI();
    }

    public void AddItemButton2()
    {
        
    }

    public void AddItemButton3()
    {
        
    }

    public void DeleteSelectedItem()
    {
        //Borrar item seleccionado con el bot�n de borrar
    }

    private void UpdateInventoryUI()
    {
        //Loopear por el inventario para actualizarlo
        for (int i = 0; i <inventory.items.Count; i++)
        {
            slots[i].SetItem(inventory.items[i]);
        }
    }
}
