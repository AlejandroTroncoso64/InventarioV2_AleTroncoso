using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
     public InventorySystem inventory;
    public Slots[] slots; //Slots asignables en inspector

    public void AddItemButton1()
    {
        //Botón para crear un nuevo item
        ItemDiamondSword newItem = new ItemDiamondSword();

        //Añadir item al inventario
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
        //Borrar item seleccionado con el botón de borrar
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
